using UnityEngine;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using USD.NET;

namespace USD.NET.Examples
{
    public class UsdInfo: MonoBehaviour
    {
        public Scene scene;
        public string path;
    }

    /*
     * UsdSceneImporter is a utility to help you load Universal Scene Description assets into Unity.
     * It works in the Unity Editor, and at runtime in a standalone build.
     * To use this, call:
     *   GameObject root = UsdSceneImporter.shared.LoadScene("/path/to/file.usd", someMaterial);
     * The full USD heirarchy will be populated under this root GameObject.
     * You can access the USD scene via ((UsdInfo)root.GetComponent<UsdInfo>()).scene
     * Also the USD path of each transform is available in a UsdInfo component on every GameObject under the root.
     */
    public class UsdSceneImporter
    {
        public static UsdSceneImporter shared = new UsdSceneImporter();

        // Keep track of all objects loaded.
        private Dictionary<string, GameObject> m_primMap = new Dictionary<string, GameObject>();

        public Transform LoadScene(string usdFile, Material defaultMaterial, float scaleFactor=0.01f, float usdTime=0.0f)
        {
            InitUsd.Initialize();

            if (string.IsNullOrEmpty(usdFile))
            {
                throw new Exception("No USD file path specified");
            }

            // Does the path exist?
            if (!System.IO.File.Exists(usdFile))
            {
                throw new Exception("USD file not found: "+usdFile);
            }

            // Import the new scene.
            Scene scene = Scene.Open(usdFile);
            if (scene == null)
            {
                throw new Exception("Failed to import");
            }

            // Set the time at which to read samples from USD.
            scene.Time = usdTime;

            // Handle configurable up-axis (Y or Z).
            Vector3 up = GetUpVector(scene);
            var rootXf = new GameObject("root");
            if (up != Vector3.up)
            {
                rootXf.transform.localRotation = Quaternion.FromToRotation(Vector3.up, up);
            }

            // Convert from right-handed (USD) to left-handed (Unity).
            // The math below works out to either (1, -1, 1) or (1, 1, -1), depending on up.
            rootXf.transform.localScale = -1 * up + -1 * (Vector3.one - up);
            rootXf.transform.localScale *= scaleFactor;

            // Assign this transform as the root.
            m_primMap.Add("/", rootXf);

            // Import transforms.
            foreach (var path in scene.AllXforms)
            {
                var xf = new USD.NET.Unity.XformSample();
                scene.Read(path, xf);
                var go = new GameObject(path.GetName());
                AssignTransform(xf, go);
                AssignParent(path, go);
                UsdInfo xinfo = go.AddComponent<UsdInfo>();
                xinfo.path = path;
            }

            // Import meshes.
            foreach (var path in scene.AllMeshes)
            {
                var mesh = new USD.NET.Unity.MeshSample();
                scene.Read(path, mesh);
                var go = new GameObject(path.GetName());
                AssignTransform(mesh, go);
                AssignParent(path, go);
                BuildMesh(mesh, go, defaultMaterial);
                UsdInfo minfo = go.AddComponent<UsdInfo>();
                minfo.path = path;
            }

            UsdInfo info = rootXf.AddComponent<UsdInfo>();
            info.scene = scene;
            info.path = "/";

            return rootXf.transform;
        }

        // Best practice: store a single value for objects that are reused, rather than recreating them.
        private readonly pxr.TfToken kUpAxisToken = new pxr.TfToken("upAxis");
        Vector3 GetUpVector(Scene scene)
        {
            pxr.VtValue valUpAxis = new pxr.VtValue();
            if (!scene.Stage.GetMetadata(kUpAxisToken, valUpAxis))
            {
                // Should never happen.
                throw new Exception("Get UpAxis failed");
            }

            // Note: currently Y and Z are the only valid values.
            // https://graphics.pixar.com/usd/docs/api/group___usd_geom_up_axis__group.html

            switch (((pxr.TfToken)valUpAxis).ToString())
            {
                case "Y":
                    // Note, this is also Unity's default up vector.
                    return Vector3.up;
                case "Z":
                    return new Vector3(0, 0, 1);
                default:
                    throw new Exception("Invalid upAxis value: " + ((pxr.TfToken)valUpAxis).ToString());
            }
        }

        // Convert Matrix4x4 into TSR components.
        void AssignTransform(USD.NET.Unity.XformSample xf, GameObject go)
        {
            go.transform.localPosition = ExtractPosition(xf.transform);
            go.transform.localScale = ExtractScale(xf.transform);
            go.transform.localRotation = ExtractRotation(xf.transform);
        }

        // Recreate hierarchy.
        void AssignParent(pxr.SdfPath path, GameObject go)
        {
            m_primMap.Add(path, go);
            go.transform.SetParent(m_primMap[path.GetParentPath()].transform, worldPositionStays: false);
        }

        // Copy mesh data to Unity and assign mesh with material.
        void BuildMesh(USD.NET.Unity.MeshSample usdMesh, GameObject go, Material material)
        {
            var mf = go.AddComponent<MeshFilter>();
            var mr = go.AddComponent<MeshRenderer>();
            var unityMesh = new UnityEngine.Mesh();
            var mat = Material.Instantiate(material);

            unityMesh.vertices = usdMesh.points;

            // Triangulate n-gons.
            // For best performance, triangulate off-line and skip conversion.
            var indices = USD.NET.Unity.UnityTypeConverter.ToVtArray(usdMesh.faceVertexIndices);
            var counts = USD.NET.Unity.UnityTypeConverter.ToVtArray(usdMesh.faceVertexCounts);
            pxr.UsdGeomMesh.Triangulate(indices, counts);
            USD.NET.Unity.UnityTypeConverter.FromVtArray(indices, ref usdMesh.faceVertexIndices);

            if (usdMesh.orientation == Orientation.LeftHanded)
            {
                // USD is right-handed, so the mesh needs to be flipped.
                // Unity is left-handed, but that doesn't matter here.
                for (int i = 0; i < usdMesh.faceVertexIndices.Length; i += 3)
                {
                    int tmp = usdMesh.faceVertexIndices[i];
                    usdMesh.faceVertexIndices[i] = usdMesh.faceVertexIndices[i + 1];
                    usdMesh.faceVertexIndices[i + 1] = tmp;
                }
            }

            unityMesh.triangles = usdMesh.faceVertexIndices;

            if (usdMesh.extent.size.x > 0 || usdMesh.extent.size.y > 0 || usdMesh.extent.size.z > 0)
            {
                unityMesh.bounds = usdMesh.extent;
            }
            else
            {
                unityMesh.RecalculateBounds();
            }

            if (usdMesh.normals != null)
            {
                unityMesh.normals = usdMesh.normals;
            }
            else
            {
                unityMesh.RecalculateNormals();
            }

            if (usdMesh.tangents != null)
            {
                unityMesh.tangents = usdMesh.tangents;
            }
            else
            {
                unityMesh.RecalculateTangents();
            }

            if (usdMesh.colors != null)
            {
                // NOTE: The following color conversion assumes PlayerSettings.ColorSpace == Linear.
                // For best performance, convert color space to linear off-line and skip conversion.

                if (usdMesh.colors.Length == 1)
                {
                    // Constant color can just be set on the material.
                    mat.color = usdMesh.colors[0].gamma;
                }
                else if (usdMesh.colors.Length == usdMesh.points.Length)
                {
                    // Vertex colors map on to verts.
                    // TODO: move the conversion to C++ and use the color management API.
                    for (int i = 0; i < usdMesh.colors.Length; i++)
                    {
                        usdMesh.colors[i] = usdMesh.colors[i].gamma;
                    }

                    unityMesh.colors = usdMesh.colors;
                }
                else
                {
                    // FaceVarying and uniform both require breaking up the mesh and are not yet handled in
                    // this example.
                    Debug.LogWarning("Uniform (color per face) and FaceVarying (color per vert per face) "
                                   + "display color not supported in this example");
                }
            }

            // As in Unity, UVs are a dynamic type which can be vec2, vec3, or vec4.
            if (usdMesh.uv != null)
            {
                Type uvType = usdMesh.uv.GetType();
                if (uvType == typeof(Vector2[]))
                {
                    unityMesh.SetUVs(0, ((Vector2[])usdMesh.uv).ToList());
                }
                else if (uvType == typeof(Vector3[]))
                {
                    unityMesh.SetUVs(0, ((Vector3[])usdMesh.uv).ToList());
                }
                else if (uvType == typeof(Vector4[]))
                {
                    unityMesh.SetUVs(0, ((Vector4[])usdMesh.uv).ToList());
                }
                else
                {
                    throw new Exception("Unexpected UV type: " + usdMesh.uv.GetType());
                }
            }

            mr.material = mat;
            mf.mesh = unityMesh;
        }

        // Destroy all previously created objects.
        public void UnloadGameObjects()
        {
            foreach (var kvp in m_primMap)
            {
                GameObject.DestroyImmediate(kvp.Value);
            }
            m_primMap.Clear();
        }

        // ------------------------------------------------------------------------------------------ //
        // Matrix4x4 helpers, not USD specific.
        // ------------------------------------------------------------------------------------------ //

        static Quaternion ExtractRotation(Matrix4x4 mat4)
        {
            Vector3 forward;
            forward.x = mat4.m02;
            forward.y = mat4.m12;
            forward.z = mat4.m22;
            Vector3 up;
            up.x = mat4.m01;
            up.y = mat4.m11;
            up.z = mat4.m21;
            return Quaternion.LookRotation(forward, up);
        }

        static Vector3 ExtractPosition(Matrix4x4 mat4)
        {
            Vector3 position;
            position.x = mat4.m03;
            position.y = mat4.m13;
            position.z = mat4.m23;
            return position;
        }

        static Vector3 ExtractScale(Matrix4x4 mat4)
        {
            Vector3 scale;
            scale.x = new Vector4(mat4.m00, mat4.m10, mat4.m20, mat4.m30).magnitude;
            scale.y = new Vector4(mat4.m01, mat4.m11, mat4.m21, mat4.m31).magnitude;
            scale.z = new Vector4(mat4.m02, mat4.m12, mat4.m22, mat4.m32).magnitude;
            return scale;
        }
    }

}
