﻿// Copyright 2018 Jeremy Cowles. All rights reserved.
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
using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.AssetImporters;

namespace USD.NET.Unity {

  [CustomEditor(typeof(UsdLayerStack))]
  public class UsdLayerStackEditor : ScriptedImporterEditor {
    public override void OnInspectorGUI() {
      var layerStack = (UsdLayerStack)this.target;

      base.DrawDefaultInspector();

      GUILayout.Space(10);

      if (GUILayout.Button("Save Overrides to Target Layer")) {
        Examples.InitUsd.Initialize();
        layerStack.SaveToLayer();
      }

      if (GUILayout.Button("Save Layer Stack")) {
        Examples.InitUsd.Initialize();
        Scene scene = Scene.Open(layerStack.GetComponent<UsdAsset>().fullPath);
        try {
          layerStack.SaveLayerStack(scene, layerStack.m_layerStack);
        } finally {
          scene.Close();
          scene = null;
        }
      }

    }

  }
}
