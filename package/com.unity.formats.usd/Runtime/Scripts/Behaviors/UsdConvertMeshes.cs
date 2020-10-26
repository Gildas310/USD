﻿using System;
using UnityEngine;
using pxr;
using Unity.Jobs;
using USD.NET;
using USD.NET.Unity;
using System.Linq;

namespace Unity.Formats.USD
{
    
//         struct ConvertGeometryJob
// #if !UNITY_2017
//       : IJobParallelFor
// #endif
//     {
//       public static Scene scene;
//       public static SdfPath[] paths;
//       public static bool changeHandedness;
//       // public static bool triangulate;
//       // public static bool unrollPrimvars;
//       public static MeshImportOptions meshOptions;
//       
//       public static GfMatrix4f basis = new GfMatrix4f(1.0f, 0.0f, 0.0f, 0.0f,
//                                                       0.0f, 1.0f, 0.0f, 0.0f,
//                                                       0.0f, 0.0f, -1.0f, 0.0f,
//                                                       0.0f, 0.0f, 0.0f, 1.0f);
//       public void Run() {
//         for (int i = 0; i < paths.Length; i++) {
//           Execute(i);
//         }
//       }
//       public void Execute(int index)
//       {
//         UsdPrim prim = scene.Stage.GetPrimAtPath(paths[index]);
//         UsdGeomMesh mesh = new UsdGeomMesh(prim);
//
//         var pointsAttr = mesh.GetPointsAttr();
//         VtVec3fArray points = pointsAttr.Get();
//         
//         // Points
//         if (changeHandedness) {
//           for (int i = 0; i < points.size(); i++)
//           {
//             points[i] = basis.Transform(points[i]);
//           }
//           pointsAttr.Set(points);
//         }
//         
//         // Topology
//         //    Triangulate
//         var fvi = mesh.GetFaceVertexIndicesAttr();
//         VtIntArray faceVertexIndices = fvi.Get();
//         var fvc = mesh.GetFaceVertexCountsAttr();
//         VtIntArray faceVertexCount = mesh.GetFaceVertexCountsAttr().Get();
//         UsdGeomMesh.Triangulate(faceVertexIndices, faceVertexCount);
//         fvi.Set(faceVertexIndices);
//         fvc.Set(faceVertexCount);
//
//         //    Handedness
//         TfToken orientation = mesh.GetOrientationAttr().Get();
//         bool isLeftHanded = orientation == UsdGeomTokens.leftHanded;
//         if (changeHandedness && !isLeftHanded || !changeHandedness && isLeftHanded) {
//           // USD is right-handed, so the mesh needs to be flipped.
//           // Unity is left-handed, but that doesn't matter here.
//           for (int i = 0; i < faceVertexIndices.size(); i += 3)
//           {
//             int tmp = faceVertexIndices[i];
//             faceVertexIndices[i] = faceVertexIndices[i + 1];
//             faceVertexIndices[i + 1] = tmp;
//           }
//         }
//         fvi.Set(faceVertexIndices);
//         
//         // Extent
//         // mesh.GetExtentAttr();
//         // if (MeshImporter.ShouldImport(meshOptions.boundingBox) && hasBounds) {
//         //   Profiler.BeginSample("Import Bounds");
//           // if (changeHandedness) {
//           //   usdMesh.extent.center = UnityTypeConverter.ChangeBasis(usdMesh.extent.center);
//           // }
//         
//         // Normals
//         // var normalsAttr = mesh.GetNormalsAttr();
//         // if (!normalsAttr.HasValue() && MeshImporter.ShouldCompute(meshOptions.normals))
//         // {
//         //   // mesh.GetSubdivisionSchemeAttr().Set(UsdGeomTokens.subdivisionScheme);
//         //   // VtVec3fArray normals = new VtVec3fArray(points.size(), new GfVec3f(0.0f, 0.0f, 0.0f)); 
//         // //   // VtIntArray faceVertexIndices = mesh.GetFaceVertexIndicesAttr().Get();
//         // //   // VtIntArray faceVertexCount = mesh.GetFaceVertexCountsAttr().Get();
//         //
//         //   Vector3[] normals = MeshImporter.ComputeNormals(UnityTypeConverter.FromVtArray(points), UnityTypeConverter.FromVtArray(faceVertexIndices));
//         // // UsdGeomMesh.ComputeNormals(points, faceVertexIndices, normals);
//         // normalsAttr.Set(UnityTypeConverter.ToVtArray(normals));
//         // //   // for (var faceAIndex = 0; faceAIndex < faceVertexCount.size(); facseAIndex++)
//         // //   // {
//         // //   //   int i0 = faceVertexIndices[faceAIndex];
//         // //   //   int i1 = faceVertexIndices[faceAIndex + 1];
//         // //   //   int i2 = faceVertexIndices[faceAIndex + 2];
//         // //   //
//         // //   //   GfVec3f e1 = points[i1];
//         // //   //   e1 -= points[i0];
//         // //   //   Vector3 e2 = points[i2] - points[i0];
//         // //   //   Vector3 n = Vector3.Cross(e1, e2);
//         // //   //
//         // //   //   normals[i0] += n;
//         // //   //   normals[i1] += n;
//         // //   //   normals[i2] += n;
//         // //   // }
//         // //   //
//         // //   // for (var i = 0; i < normals.Length; i++)
//         // //   // {
//         // //   //   normals[i].Normalize();
//         // //   // }
//         // }
//       }
//     }


  public class UsdConvertMeshes : MonoBehaviour, IImportPostProcessHierarchy
  {
    private Scene _scene;

    public Scene Scene
    {
      get => _scene;
      set => _scene = value;
    }

    public void PostProcessHierarchy(PrimMap primMap, SceneImportOptions sceneImportOptions)
    {
      // ReadSamples(primMap, sceneImportOptions);
      ReadUsd(primMap, sceneImportOptions);

      _scene.Stage.GetSessionLayer().Export("D:\\session.usda");
    }


    public void ReadSamples(PrimMap primMap, SceneImportOptions sceneImportOptions)
    {
      var readMeshes = new ReadAllJob<MeshSample>(Scene, primMap.Meshes);
      readMeshes.Schedule(primMap.Meshes.Length, 4);

      bool changeHandedness = sceneImportOptions.changeHandedness == BasisTransformation.SlowAndSafe ||
                              sceneImportOptions.changeHandedness == BasisTransformation.SlowAndSafeAsFBX;



      foreach (var pathAndSample in readMeshes)
      {
        MeshSample usdMesh = pathAndSample.sample;

        // Points
        if (changeHandedness)
        {
          var newVertices = new Vector3[usdMesh.points.Length];
          for (int i = 0; i < usdMesh.points.Length; i++)
          {
            newVertices[i] = UnityTypeConverter.ChangeBasis(usdMesh.points[i]);
          }

          usdMesh.points = newVertices;
        }

        // Topology
        var indices = UnityTypeConverter.ToVtArray(usdMesh.faceVertexIndices);
        var counts = UnityTypeConverter.ToVtArray(usdMesh.faceVertexCounts);
        UsdGeomMesh.Triangulate(indices, counts);
        usdMesh.faceVertexIndices = UnityTypeConverter.FromVtArray(indices);


        bool isLeftHanded = usdMesh.orientation == Orientation.LeftHanded;
        if (changeHandedness && !isLeftHanded || !changeHandedness && isLeftHanded)
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


        // Normals
        if (usdMesh.normals != null && MeshImporter.ShouldImport(sceneImportOptions.meshOptions.normals))
        {
          // Profiler.BeginSample("Import Normals");
          if (changeHandedness)
          {
            for (int i = 0; i < usdMesh.points.Length; i++)
            {
              usdMesh.normals[i] = UnityTypeConverter.ChangeBasis(usdMesh.normals[i]);
            }
          }

          // If more normals than verts, assume face-varying.
          // if (usdMesh.normals.Length > usdMesh.points.Length) {
          //   usdMesh.normals = UnrollFaceVarying(usdMesh.points.Length, usdMesh.normals, usdMesh.faceVertexCounts, originalIndices);
          // }
          // unityMesh.normals = usdMesh.normals;
          // Profiler.EndSample();
        }
        else if (MeshImporter.ShouldCompute(sceneImportOptions.meshOptions.normals))
        {
          // Profiler.BeginSample("Calculate Normals");
          VtVec3fArray normals = new VtVec3fArray(checked((uint) usdMesh.points.Length));
          UsdGeomMesh.ComputeNormals(UnityTypeConverter.ToVtArray(usdMesh.points),
            UnityTypeConverter.ToVtArray(usdMesh.faceVertexIndices),
            normals);
          usdMesh.normals = UnityTypeConverter.FromVtArray(normals);
          // Profiler.EndSample();
        }

        // Tangents

        // Unroll
        if (true)
        {
          // If there is attributes that are face varying we need to "unroll" the usd mesh points to make sure
          // that each unity mesh vertex (position + attributes can be unique).
          usdMesh.points = MeshImporter.UnrollPrimvars(usdMesh.points, usdMesh.faceVertexIndices);
          // pointsAttr.Set(points);


          usdMesh.normals = MeshImporter.UnrollPrimvars(usdMesh.normals, usdMesh.faceVertexIndices);

          // var colorAttr = mesh.GetDisplayColorPrimvar();
          // VtVec3fArray colors = colorAttr.Get();
          // UnrollPrimvars(colors, faceVertexIndices);
          // colorAttr.Set(colors);
          // var colorAttr = mesh.GetDisplayColorPrimvar();
          // ConvertPrimvarToFaceVarying(colorAttr, faceVertexIndices);
          //
          // // var st = mesh.GetPrimvar(new TfToken("st"));
          // // ConvertPrimvarToFaceVarying(st, faceVertexIndices);
          //         
          // // Now that all attributes and primvar are converted to facevarying, update the faceIndices
          // VtIntArray newIndices = new VtIntArray(faceVertexIndices.size());
          // newIndices.CopyFromArray(Enumerable.Range(0, checked((int)faceVertexIndices.size())).ToArray());
          // fvi.Set(newIndices);
        }

        Scene.Write(pathAndSample.path, usdMesh);
      }
    }

    public void ReadUsd(PrimMap primMap, SceneImportOptions sceneImportOptions)
    {


      var usdAsset = gameObject.GetComponent<UsdAsset>();
      bool changeHandedness = sceneImportOptions.changeHandedness == BasisTransformation.SlowAndSafe ||
                              sceneImportOptions.changeHandedness == BasisTransformation.SlowAndSafeAsFBX;


      GfMatrix4f basis = new GfMatrix4f(1.0f, 0.0f, 0.0f, 0.0f,
        0.0f, 1.0f, 0.0f, 0.0f,
        0.0f, 0.0f, -1.0f, 0.0f,
        0.0f, 0.0f, 0.0f, 1.0f);

      foreach (var prim in primMap.Meshes)
      {
        UsdGeomMesh mesh = new UsdGeomMesh(_scene.Stage.GetPrimAtPath(prim));

        TfToken targetInterpolation;
        bool unrollAttributes = ComputeIfUnrollNeeded(mesh, sceneImportOptions);

        var pointsAttr = mesh.GetPointsAttr();
        VtVec3fArray points = pointsAttr.Get();
        var fvi = mesh.GetFaceVertexIndicesAttr();
        VtIntArray faceVertexIndices = fvi.Get();
        VtIntArray faceVertexIndicesOriginal = fvi.Get();
        var fvc = mesh.GetFaceVertexCountsAttr();
        VtIntArray faceVertexCount = mesh.GetFaceVertexCountsAttr().Get();
        VtIntArray faceVertexCountOrig = new VtIntArray(faceVertexCount);

        // Points
        if (changeHandedness)
        {
          for (int i = 0; i < points.size(); i++)
          {
            points[i] = basis.Transform(points[i]);
          }

          pointsAttr.Set(points);
        }

        // Topology
        //    Triangulate
        int[] faceMapping = ComputeFaceMapping(faceVertexCount);
        UsdGeomMesh.Triangulate(faceVertexIndices, faceVertexCount);

        //    Handedness
        TfToken orientation = mesh.GetOrientationAttr().Get();
        bool isLeftHanded = orientation == UsdGeomTokens.leftHanded;
        if (changeHandedness && !isLeftHanded || !changeHandedness && isLeftHanded)
        {
          // USD is right-handed, so the mesh needs to be flipped.
          // Unity is left-handed, but that doesn't matter here.
          for (int i = 0; i < faceVertexIndices.size(); i += 3)
          {
            int tmp = faceVertexIndices[i];
            faceVertexIndices[i] = faceVertexIndices[i + 1];
            faceVertexIndices[i + 1] = tmp;
          }
        }

        fvi.Set(faceVertexIndices);
        fvc.Set(faceVertexCount);


        // Normals
        var normalsAttr = mesh.GetNormalsAttr();
        if (normalsAttr.HasValue() && MeshImporter.ShouldImport(sceneImportOptions.meshOptions.normals))
        {
          //   Handedness
          VtVec3fArray normals = normalsAttr.Get();
          if (changeHandedness)
          {
            for (int i = 0; i < normals.size(); i++)
            {
              normals[i] = basis.Transform(normals[i]);
            }
          }

          normalsAttr.Set(normals);
        }
        else if (MeshImporter.ShouldCompute(sceneImportOptions.meshOptions.normals))
        {
          //   Compute missing normals
          VtVec3fArray normals = new VtVec3fArray(points.size());
          UsdGeomMesh.ComputeNormals(points, faceVertexIndices, normals);
          normalsAttr.Set(normals);
        }

        // TODO: BBox

        // TODO: Tangents

        // TODO: UVs

        
        if (unrollAttributes)
        {
          // If there is attributes that are face varying we need to "unroll" the usd mesh points to make sure
          // that each unity mesh vertex (position + attributes can be unique).
          UnrollAttributes(points, faceVertexIndices);
          pointsAttr.Set(points);


          VtVec3fArray normals = normalsAttr.Get();
          UnrollAttributes(normals, faceVertexIndices);
          normalsAttr.Set(normals);
          mesh.SetNormalsInterpolation(UsdGeomTokens.faceVarying);
        
          var colorAttr = mesh.GetDisplayColorPrimvar();
          ConvertPrimvarInterpolation(colorAttr, faceVertexIndices, faceVertexCountOrig, faceMapping);
          
          var opacityAttr = mesh.GetDisplayOpacityPrimvar();
          ConvertPrimvarInterpolation(opacityAttr, faceVertexIndices, faceVertexCountOrig, faceMapping);

          var st = mesh.GetPrimvar(new TfToken("st"));
          ConvertPrimvarInterpolation(st, faceVertexIndices, faceVertexCountOrig, faceMapping);
          
          var uv = mesh.GetPrimvar(new TfToken("uv"));
          ConvertPrimvarInterpolation(uv, faceVertexIndices, faceVertexCountOrig, faceMapping);
          
          var uv2 = mesh.GetPrimvar(new TfToken("uv2"));
          ConvertPrimvarInterpolation(uv2, faceVertexIndices, faceVertexCountOrig, faceMapping);
          
          var uv3 = mesh.GetPrimvar(new TfToken("uv3"));
          ConvertPrimvarInterpolation(uv3, faceVertexIndices, faceVertexCountOrig, faceMapping);
          
          var uv4 = mesh.GetPrimvar(new TfToken("uv4"));
          ConvertPrimvarInterpolation(uv4, faceVertexIndices, faceVertexCountOrig, faceMapping);
          

        // Now that all attributes and primvar are converted to facevarying, update the faceIndices
          VtIntArray newIndices = new VtIntArray(faceVertexIndices.size());
          newIndices.CopyFromArray(Enumerable.Range(0, checked((int) faceVertexIndices.size())).ToArray());
          fvi.Set(newIndices);
        }
      }
    }

    private static bool ComputeIfUnrollNeeded(UsdGeomMesh usdMesh, SceneImportOptions options)
    {
      // If any primvar is face varying (1 value per vertex) or uniform (1 value per face), all  primvars + mesh attributes will have to be unrolled
      return (usdMesh.GetNormalsInterpolation() == UsdGeomTokens.uniform ||
              usdMesh.GetNormalsInterpolation() == UsdGeomTokens.faceVarying ||
              usdMesh.GetDisplayColorPrimvar().GetInterpolation() == UsdGeomTokens.uniform ||
              usdMesh.GetDisplayColorPrimvar().GetInterpolation() == UsdGeomTokens.faceVarying ||
              usdMesh.GetDisplayOpacityPrimvar().GetInterpolation() == UsdGeomTokens.uniform ||
              usdMesh.GetDisplayOpacityPrimvar().GetInterpolation() == UsdGeomTokens.faceVarying ||
              (options.ShouldBindMaterials &&
               (usdMesh.GetPrimvar(new TfToken("st")).GetInterpolation() == UsdGeomTokens.faceVarying ||
                usdMesh.GetPrimvar(new TfToken("uv")).GetInterpolation() == UsdGeomTokens.faceVarying ||
                usdMesh.GetPrimvar(new TfToken("uv2")).GetInterpolation() == UsdGeomTokens.faceVarying ||
                usdMesh.GetPrimvar(new TfToken("uv3")).GetInterpolation() == UsdGeomTokens.faceVarying ||
                usdMesh.GetPrimvar(new TfToken("uv4")).GetInterpolation() == UsdGeomTokens.faceVarying)));
    }

    private static void UnrollAttributes(VtVec3fArray vertices, VtIntArray indices)
    {
      uint indicesCount = indices.size();
      VtVec3fArray newPoints = new VtVec3fArray(indicesCount);

      for (int i = 0; i < indicesCount; i++)
      {
        int vertexIndex = indices[i];
        newPoints[i] = vertices[vertexIndex];
      }

      vertices.swap(newPoints);
    }
    
    private static void UnrollAttributes(VtVec2fArray vertices, VtIntArray indices)
    {
      uint indicesCount = indices.size();
      VtVec2fArray newPoints = new VtVec2fArray(indicesCount);

      for (int i = 0; i < indicesCount; i++)
      {
        int vertexIndex = indices[i];
        newPoints[i] = vertices[vertexIndex];
      }

      vertices.swap(newPoints);
    }

    static void TriangulateFaceVaryingPrimvar(ref VtVec2fArray data, VtIntArray faceVertexCount, uint size, bool changeHandedness)
    {
      VtVec2fArray result = new VtVec2fArray();
      result.reserve(size);
      int last = 0;
      int next = 1;
      for (int i = 0; i < faceVertexCount.size(); i++)
      {
        next = last + 1;
        for (int t = 0; t < faceVertexCount[i] - 2; t++)
        {

          if (changeHandedness)
          {
            result.push_back(data[next++]);
            result.push_back(data[last]);
            result.push_back(data[next]);  
          }
          else
          {
            result.push_back(data[last]);
            result.push_back(data[next++]);
            result.push_back(data[next]);
          }
          
        }

        last += faceVertexCount[i];
      }
      data.swap(result);
      result.Dispose();
    }
    
    static void TriangulateFaceVaryingPrimvar(ref VtVec3fArray data, VtIntArray faceVertexCount, uint size, bool changeHandedness)
    {
      VtVec3fArray result = new VtVec3fArray();
      result.reserve(size);
      int last = 0;
      int next = 1;
      for (int i = 0; i < faceVertexCount.size(); i++)
      {
        next = last + 1;
        for (int t = 0; t < faceVertexCount[i] - 2; t++)
        {
          if (changeHandedness)
          {
            result.push_back(data[next++]);
            result.push_back(data[last]);
            result.push_back(data[next]);
          }
          else
          {
            result.push_back(data[last]);
            result.push_back(data[next++]);
            result.push_back(data[next]);
          }
        }

        last += faceVertexCount[i];
      }
      data.swap(result);
      result.Dispose();
    }

   
    // UsdGeomSubsets contain a list of face indices, but once the mesh is triangulated, these
    // indices are no longer correct. The number of new faces generated is a fixed function of
    // the original face indices, but the offset requires an accumulation of all triangulated
    // face offsets, this is "offsetMapping". The index into offsetMapping is the original
    // face index and the value at that index is the new face offset.
    private static int[] ComputeFaceMapping(VtIntArray faceVertexCount)
    {
      int[] faceOffsetMapping = new int[faceVertexCount.size()];
      int curOffset = 0;
      for (int i = 0; i < faceVertexCount.size(); i++) {
        faceOffsetMapping[i] = curOffset;
        curOffset += Math.Max(0, faceVertexCount[i] - 3);
      }

      return faceOffsetMapping;
    }

    // bool ComputeFlattenedHelper<T>(const T values, ref T flattened, VtIntArray indices)
    // {
    //   // flattened.
    //   // std::vector<size_t> invalidIndexPositions;
    //   for (uint i=0; i < indices.size(); i++) {
    //     int index = indices[i];
    //     if (index >= 0 && (size_t)index < values.size()) {
    //       (*flattened)[i] = values[index];
    //     } 
    //     // else {
    //     //   invalidIndexPositions.push_back(i);
    //     //   success = false;
    //     // }
    //   }
    // }
    //
    // bool ComputeFlattened<T>(const VtValue values, ref VtValue flattened, VtIntArray indices)
    // {
    //   var vf = UsdCs.VtValueToVtFloatArray(val);
    //   if (vf != null && !vf.empty())
    //   {
    //     var flattenedArray = UsdCs.VtValueToVtFloatArray(flattened);
    //     var success = ComputeFlattenedHelper(vf, flattenedArray, indices);
    //     flattened.
    //     return;
    //   }
    //     
    //   var v2f = UsdCs.VtValueToVtVec2fArray(val);
    //   if (v2f != null && !v2f.empty())
    //   {
    //     // DO IT
    //     return;
    //   }
    //  
    // }
    
    // Unity surface attributes are stored per vertex so USD primvars need to be unrolled to match the number of vertices.
    // If we detect facevarying attributes, the points are unwelded
    // More info on primvar interpolation: https://graphics.pixar.com/usd/docs/api/class_usd_geom_primvar.html#Usd_InterpolationVals
    // constant: one constant value over the surface
    // uniform: one value per face
    // varying/vertex: same meaning for polygonal meshes, one value per vertex
    // face varying: one value per vertex per face
    private void ConvertPrimvarInterpolation(UsdGeomPrimvar primVar,
                                             VtIntArray indices,
                                             VtIntArray faceVertexCount,
                                             int[] faceOffset)
    {
      uint count = indices.size();
      
      // Unroll indexed primvars
      // VtIntArray vtIndices = new VtIntArray();
      // var val = primVar.GetAttr().Get();
      // primVar.get
      VtValue val = new VtValue();
      primVar.ComputeFlattened(val);
      string errString = "";
      // Use the static version of computeFlattened as the instance crashes
      // if (primVar.IsIndexed())
      // {
      //   VtIntArray ids = new VtIntArray();
      //   primVar.GetIndices(ids);
      //   UsdGeomPrimvar.ComputeFlattened(val, flattened, ids, out errString);
      //   var array = flattened.IsArrayValued();
      // }
      // else
      //   flattened = val;
      // if (primVar.GetIndices(vtIndices, 0.0)) {
      //   var flatVal = new VtValue();
      //   for(int idx = 0; idx < vtIndices.size(); idx++)
      //     values = indices.Select(idx => val[idx]).ToArray();
      // }
      
      var interpolation = primVar.GetInterpolation();

      // Constant = 
      if (interpolation == UsdGeomTokens.constant)
      {
        // Ignore, it's supported by the importer 
      }
      else if (interpolation == UsdGeomTokens.uniform)
      {
        var vf = UsdCs.VtValueToVtFloatArray(val);
        if (vf != null && !vf.empty())
        {
          // DO IT
          return;
        }
        
        var v2f = UsdCs.VtValueToVtVec2fArray(val);
        if (v2f != null && !v2f.empty())
        {
          // DO IT
          return;
        }

        var v3f = UsdCs.VtValueToVtVec3fArray(val);
        if (v3f != null && !v3f.empty())
        {
          VtVec3fArray newColors = new VtVec3fArray(count);
          for (int faceIndex = 0; faceIndex < indices.size() / 3; faceIndex++)
          {
            // The mesh has been triangulated, let's assume for now it was all quads before :/
            newColors[faceIndex * 3 + 0] = v3f[faceIndex / 2];
            newColors[faceIndex * 3 + 1] = v3f[faceIndex / 2];
            newColors[faceIndex * 3 + 2] = v3f[faceIndex / 2];
          }

          primVar.GetAttr().Set(newColors);
          primVar.SetInterpolation(UsdGeomTokens.faceVarying);
          return;
        }
        
        var v4f = UsdCs.VtValueToVtVec4fArray(val);
        if (v4f != null && !v4f.empty())
        {
          // DO IT
          return;
        }
      }
      else if (interpolation == UsdGeomTokens.vertex ||
               interpolation == UsdGeomTokens.varying)
      {
        var vf = UsdCs.VtValueToVtFloatArray(val);
        if (vf != null && !vf.empty())
        {
          // DO IT
          return;
        }
        
        var v2f = UsdCs.VtValueToVtVec2fArray(val);
        if (v2f != null && !v2f.empty())
        {
          // DO IT
          return;
        }

        var v3f = UsdCs.VtValueToVtVec3fArray(val);
        if (v3f != null && !v3f.empty())
        {
          UnrollAttributes(v3f, indices);
          primVar.GetAttr().Set(v3f);
          primVar.SetInterpolation(UsdGeomTokens.faceVarying);
          return;
        }
        
        var v4f = UsdCs.VtValueToVtVec4fArray(val);
        if (v4f != null && !v4f.empty())
        {
          // DO IT
          return;
        }
      }
      else if (primVar.GetInterpolation() == UsdGeomTokens.faceVarying)
      {
        // No need to unroll
        // TODO: indexed values are not supported
        var a = val.IsArrayValued();
        var b = val.GetArraySize();
        
        var v2f = UsdCs.VtValueToVtVec2fArray(val);
        if (v2f != null && !v2f.empty())
        {
          // UnrollAttributes(v2f, indices);
          TriangulateFaceVaryingPrimvar(ref v2f, faceVertexCount, indices.size(), true);
          primVar.GetAttr().Set(v2f);
          return;
        }
        
        var v3f = UsdCs.VtValueToVtVec3fArray(val);
        if (v3f != null && !v3f.empty())
        {
          // UnrollAttributes(v3f, indices);
          TriangulateFaceVaryingPrimvar(ref v3f, faceVertexCount, indices.size(), true);
          primVar.GetAttr().Set(v3f);
          return;
        }
        
        var v4f = UsdCs.VtValueToVtVec4fArray(val);
        if (v4f != null && !v4f.empty())
        {
          // DO IT
          return;
        }
      }
    }
  }
}