﻿// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;

namespace USD.NET.Unity {
  [UsdSchema("Mesh")]
  public class MeshSampleBase : XformSample {
    public Bounds extent;
    public int[] faceVertexIndices;
    public Vector3[] points;
    public Vector3[] normals;
    [VertexData]
    public Vector4[] tangents;

    // USD splits display color from opacity, which allows opacity to be overridden without
    // writing color, however the cost of recombining these in C# is too great (time/memory), so
    // instead, they are fused during serialization in C++.
    [VertexData, FusedDisplayColor]
    public Color[] colors;

    // UV object types should be Vector{2,3,4}[], List<Vector{2,3,4}>, or null.
    [VertexData]
    public object uv;
    [VertexData]
    public object uv2;
    [VertexData]
    public object uv3;
    [VertexData]
    public object uv4;
  }
}
