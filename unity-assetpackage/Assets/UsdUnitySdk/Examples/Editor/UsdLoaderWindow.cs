using UnityEngine;
using UnityEditor;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using USD.NET;

namespace USD.NET.Examples
{
    public class UsdLoaderWindow : EditorWindow
    {
        string m_errorMessage;
        private GUIStyle m_errorStyle;

        public string m_usdFile;
        public Material m_material;
        public float m_usdTime;

        // Default to USD cm into Unity meters
        public float m_scaleFactor = 0.01f;

        private Scene m_scene;

        [MenuItem("Assets/Import USD...")]
        static void Init()
        {
            // Get existing open window or if none, make a new one:
            UsdLoaderWindow window = (UsdLoaderWindow)EditorWindow.GetWindow(typeof(UsdLoaderWindow));
            window.m_errorStyle = new GUIStyle(EditorStyles.label);
            window.m_errorStyle.normal.textColor = Color.red;
            window.m_material = new Material(Shader.Find("Standard"));
            window.Show();
        }

        void OnGUI()
        {
            GUILayout.Label("Import Universal Scene Description", EditorStyles.boldLabel);

            EditorGUILayout.BeginHorizontal();

            m_usdFile = EditorGUILayout.TextField("USD File", m_usdFile);
            if (GUILayout.Button("Choose...", GUILayout.Width(80)))
            {
                string path = EditorUtility.OpenFilePanel("Import USD", "", "usd,usda,usdb");
                if (path.Length != 0)
                {
                    m_usdFile = path;
                }
            }

            EditorGUILayout.EndHorizontal();

            m_scaleFactor = EditorGUILayout.FloatField("Scale Factor", m_scaleFactor);

            m_material = (Material)EditorGUILayout.ObjectField("Material", m_material, typeof(Material), true);

            if (!string.IsNullOrEmpty(m_errorMessage))
            {
                GUILayout.Label(m_errorMessage, m_errorStyle);
            }
            else if (string.IsNullOrEmpty(m_usdFile))
            {
                GUILayout.Label("Choose a USD file.");
                GUILayout.Label("If you need a sample USD file, you can get some here:");
                string url = "http://graphics.pixar.com/usd/downloads.html";
                if (GUILayout.Button(url))
                {
                    Application.OpenURL(url);
                }
            }
            else if (m_material == null)
            {
                GUILayout.Label("Choose a material.");
            }
            else
            {
                if (GUILayout.Button("Load"))
                {
                    m_errorMessage = null;
                    EditorUtility.DisplayProgressBar("Import USD", "Importing " + m_usdFile, 0.25f);

                    Load();

                    EditorUtility.ClearProgressBar();

                    if (m_errorMessage == null)
                    {
                        Close();
                    }
                }
            }
        }

        void Load()
        {
            Debug.Log("Initializing USD...");
            InitUsd.Initialize();

            if (string.IsNullOrEmpty(m_usdFile))
            {
                m_errorMessage = "Please choose a file to load.";
                if (m_scene == null)
                {
                    return;
                }
                m_scene.Close();
                m_scene = null;
                UsdSceneImporter.shared.UnloadGameObjects();
                return;
            }

            // Is the stage already loaded?
            if (m_scene != null && m_scene.Stage.GetRootLayer().GetIdentifier() == m_usdFile)
            {
                return;
            }

            // Does the path exist?
            if (!System.IO.File.Exists(m_usdFile))
            {
                m_errorMessage = "File not found: " + m_usdFile;
                return;
            }

            // Clear out the old scene.
            UsdSceneImporter.shared.UnloadGameObjects();

            // Import the new scene.
            var root = UsdSceneImporter.shared.LoadScene(m_usdFile, m_material, m_scaleFactor, m_usdTime);
            m_scene = root.GetComponent<UsdInfo>().scene;
            if (m_scene == null)
            {
                m_errorMessage = "Failed to import. See console for details.";
                throw new Exception("Failed to import");
            }

            // Ensure the file and the identifier match.
            m_usdFile = m_scene.Stage.GetRootLayer().GetIdentifier();
        }
    }
}
