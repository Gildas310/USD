//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class PcpCache : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PcpCache(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PcpCache obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PcpCache() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_PcpCache(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public PcpCache(PcpLayerStackIdentifier layerStackIdentifier, string fileFormatTarget, bool usd) : this(UsdCsPINVOKE.new_PcpCache__SWIG_0(PcpLayerStackIdentifier.getCPtr(layerStackIdentifier), fileFormatTarget, usd), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public PcpCache(PcpLayerStackIdentifier layerStackIdentifier, string fileFormatTarget) : this(UsdCsPINVOKE.new_PcpCache__SWIG_1(PcpLayerStackIdentifier.getCPtr(layerStackIdentifier), fileFormatTarget), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public PcpCache(PcpLayerStackIdentifier layerStackIdentifier) : this(UsdCsPINVOKE.new_PcpCache__SWIG_2(PcpLayerStackIdentifier.getCPtr(layerStackIdentifier)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public PcpLayerStackIdentifier GetLayerStackIdentifier() {
    PcpLayerStackIdentifier ret = new PcpLayerStackIdentifier(UsdCsPINVOKE.PcpCache_GetLayerStackIdentifier(swigCPtr), true);
    return ret;
  }

  public PcpLayerStackPtr GetLayerStack() {
    PcpLayerStackPtr ret = new PcpLayerStackPtr(UsdCsPINVOKE.PcpCache_GetLayerStack(swigCPtr), true);
    return ret;
  }

  public bool IsUsd() {
    bool ret = UsdCsPINVOKE.PcpCache_IsUsd(swigCPtr);
    return ret;
  }

  public string GetFileFormatTarget() {
    string ret = UsdCsPINVOKE.PcpCache_GetFileFormatTarget(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_std__mapT_std__string_std__vectorT_std__string_t_std__lessT_std__string_t_t GetVariantFallbacks() {
    SWIGTYPE_p_std__mapT_std__string_std__vectorT_std__string_t_std__lessT_std__string_t_t ret = new SWIGTYPE_p_std__mapT_std__string_std__vectorT_std__string_t_std__lessT_std__string_t_t(UsdCsPINVOKE.PcpCache_GetVariantFallbacks(swigCPtr), true);
    return ret;
  }

  public void SetVariantFallbacks(SWIGTYPE_p_std__mapT_std__string_std__vectorT_std__string_t_std__lessT_std__string_t_t map, SWIGTYPE_p_PcpChanges changes) {
    UsdCsPINVOKE.PcpCache_SetVariantFallbacks__SWIG_0(swigCPtr, SWIGTYPE_p_std__mapT_std__string_std__vectorT_std__string_t_std__lessT_std__string_t_t.getCPtr(map), SWIGTYPE_p_PcpChanges.getCPtr(changes));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetVariantFallbacks(SWIGTYPE_p_std__mapT_std__string_std__vectorT_std__string_t_std__lessT_std__string_t_t map) {
    UsdCsPINVOKE.PcpCache_SetVariantFallbacks__SWIG_1(swigCPtr, SWIGTYPE_p_std__mapT_std__string_std__vectorT_std__string_t_std__lessT_std__string_t_t.getCPtr(map));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsPayloadIncluded(SdfPath path) {
    bool ret = UsdCsPINVOKE.PcpCache_IsPayloadIncluded(swigCPtr, SdfPath.getCPtr(path));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__unordered_setT_SdfPath_SdfPath__Hash_t GetIncludedPayloads() {
    SWIGTYPE_p_std__unordered_setT_SdfPath_SdfPath__Hash_t ret = new SWIGTYPE_p_std__unordered_setT_SdfPath_SdfPath__Hash_t(UsdCsPINVOKE.PcpCache_GetIncludedPayloads(swigCPtr), false);
    return ret;
  }

  public void RequestPayloads(SWIGTYPE_p_std__setT_SdfPath_t pathsToInclude, SWIGTYPE_p_std__setT_SdfPath_t pathsToExclude, SWIGTYPE_p_PcpChanges changes) {
    UsdCsPINVOKE.PcpCache_RequestPayloads__SWIG_0(swigCPtr, SWIGTYPE_p_std__setT_SdfPath_t.getCPtr(pathsToInclude), SWIGTYPE_p_std__setT_SdfPath_t.getCPtr(pathsToExclude), SWIGTYPE_p_PcpChanges.getCPtr(changes));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RequestPayloads(SWIGTYPE_p_std__setT_SdfPath_t pathsToInclude, SWIGTYPE_p_std__setT_SdfPath_t pathsToExclude) {
    UsdCsPINVOKE.PcpCache_RequestPayloads__SWIG_1(swigCPtr, SWIGTYPE_p_std__setT_SdfPath_t.getCPtr(pathsToInclude), SWIGTYPE_p_std__setT_SdfPath_t.getCPtr(pathsToExclude));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RequestLayerMuting(StdStringVector layersToMute, StdStringVector layersToUnmute, SWIGTYPE_p_PcpChanges changes) {
    UsdCsPINVOKE.PcpCache_RequestLayerMuting__SWIG_0(swigCPtr, StdStringVector.getCPtr(layersToMute), StdStringVector.getCPtr(layersToUnmute), SWIGTYPE_p_PcpChanges.getCPtr(changes));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RequestLayerMuting(StdStringVector layersToMute, StdStringVector layersToUnmute) {
    UsdCsPINVOKE.PcpCache_RequestLayerMuting__SWIG_1(swigCPtr, StdStringVector.getCPtr(layersToMute), StdStringVector.getCPtr(layersToUnmute));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public StdStringVector GetMutedLayers() {
    StdStringVector ret = new StdStringVector(UsdCsPINVOKE.PcpCache_GetMutedLayers(swigCPtr), false);
    return ret;
  }

  public bool IsLayerMuted(string layerIdentifier) {
    bool ret = UsdCsPINVOKE.PcpCache_IsLayerMuted__SWIG_0(swigCPtr, layerIdentifier);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsLayerMuted(SdfLayerHandle anchorLayer, string layerIdentifier, SWIGTYPE_p_std__string canonicalMutedLayerIdentifier) {
    bool ret = UsdCsPINVOKE.PcpCache_IsLayerMuted__SWIG_1(swigCPtr, SdfLayerHandle.getCPtr(anchorLayer), layerIdentifier, SWIGTYPE_p_std__string.getCPtr(canonicalMutedLayerIdentifier));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsLayerMuted(SdfLayerHandle anchorLayer, string layerIdentifier) {
    bool ret = UsdCsPINVOKE.PcpCache_IsLayerMuted__SWIG_2(swigCPtr, SdfLayerHandle.getCPtr(anchorLayer), layerIdentifier);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_PcpPrimIndexInputs GetPrimIndexInputs() {
    SWIGTYPE_p_PcpPrimIndexInputs ret = new SWIGTYPE_p_PcpPrimIndexInputs(UsdCsPINVOKE.PcpCache_GetPrimIndexInputs(swigCPtr), true);
    return ret;
  }

  public PcpLayerStack ComputeLayerStack(PcpLayerStackIdentifier identifier, SWIGTYPE_p_PcpErrorVector allErrors) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.PcpCache_ComputeLayerStack(swigCPtr, PcpLayerStackIdentifier.getCPtr(identifier), SWIGTYPE_p_PcpErrorVector.getCPtr(allErrors));
    PcpLayerStack ret = (cPtr == global::System.IntPtr.Zero) ? null : new PcpLayerStack(cPtr, true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PcpLayerStackPtr FindLayerStack(PcpLayerStackIdentifier identifier) {
    PcpLayerStackPtr ret = new PcpLayerStackPtr(UsdCsPINVOKE.PcpCache_FindLayerStack(swigCPtr, PcpLayerStackIdentifier.getCPtr(identifier)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PcpPrimIndex ComputePrimIndex(SdfPath primPath, SWIGTYPE_p_PcpErrorVector allErrors) {
    PcpPrimIndex ret = new PcpPrimIndex(UsdCsPINVOKE.PcpCache_ComputePrimIndex(swigCPtr, SdfPath.getCPtr(primPath), SWIGTYPE_p_PcpErrorVector.getCPtr(allErrors)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PcpPrimIndex FindPrimIndex(SdfPath primPath) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.PcpCache_FindPrimIndex(swigCPtr, SdfPath.getCPtr(primPath));
    PcpPrimIndex ret = (cPtr == global::System.IntPtr.Zero) ? null : new PcpPrimIndex(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PcpPropertyIndex ComputePropertyIndex(SdfPath propPath, SWIGTYPE_p_PcpErrorVector allErrors) {
    PcpPropertyIndex ret = new PcpPropertyIndex(UsdCsPINVOKE.PcpCache_ComputePropertyIndex(swigCPtr, SdfPath.getCPtr(propPath), SWIGTYPE_p_PcpErrorVector.getCPtr(allErrors)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PcpPropertyIndex FindPropertyIndex(SdfPath propPath) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.PcpCache_FindPropertyIndex(swigCPtr, SdfPath.getCPtr(propPath));
    PcpPropertyIndex ret = (cPtr == global::System.IntPtr.Zero) ? null : new PcpPropertyIndex(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ComputeRelationshipTargetPaths(SdfPath relationshipPath, SdfPathVector paths, bool localOnly, SdfSpecHandle stopProperty, bool includeStopProperty, SdfPathVector deletedPaths, SWIGTYPE_p_PcpErrorVector allErrors) {
    UsdCsPINVOKE.PcpCache_ComputeRelationshipTargetPaths(swigCPtr, SdfPath.getCPtr(relationshipPath), SdfPathVector.getCPtr(paths), localOnly, SdfSpecHandle.getCPtr(stopProperty), includeStopProperty, SdfPathVector.getCPtr(deletedPaths), SWIGTYPE_p_PcpErrorVector.getCPtr(allErrors));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ComputeAttributeConnectionPaths(SdfPath attributePath, SdfPathVector paths, bool localOnly, SdfSpecHandle stopProperty, bool includeStopProperty, SdfPathVector deletedPaths, SWIGTYPE_p_PcpErrorVector allErrors) {
    UsdCsPINVOKE.PcpCache_ComputeAttributeConnectionPaths(swigCPtr, SdfPath.getCPtr(attributePath), SdfPathVector.getCPtr(paths), localOnly, SdfSpecHandle.getCPtr(stopProperty), includeStopProperty, SdfPathVector.getCPtr(deletedPaths), SWIGTYPE_p_PcpErrorVector.getCPtr(allErrors));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_SdfLayerHandleSet GetUsedLayers() {
    SWIGTYPE_p_SdfLayerHandleSet ret = new SWIGTYPE_p_SdfLayerHandleSet(UsdCsPINVOKE.PcpCache_GetUsedLayers(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_SdfLayerHandleSet GetUsedRootLayers() {
    SWIGTYPE_p_SdfLayerHandleSet ret = new SWIGTYPE_p_SdfLayerHandleSet(UsdCsPINVOKE.PcpCache_GetUsedRootLayers(swigCPtr), true);
    return ret;
  }

  public PcpLayerStackPtrVector FindAllLayerStacksUsingLayer(SdfLayerHandle layer) {
    PcpLayerStackPtrVector ret = new PcpLayerStackPtrVector(UsdCsPINVOKE.PcpCache_FindAllLayerStacksUsingLayer(swigCPtr, SdfLayerHandle.getCPtr(layer)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_PcpDependencyVector FindSiteDependencies(PcpLayerStackPtr siteLayerStack, SdfPath sitePath, SWIGTYPE_p_PcpDependencyFlags depMask, bool recurseOnSite, bool recurseOnIndex, bool filterForExistingCachesOnly) {
    SWIGTYPE_p_PcpDependencyVector ret = new SWIGTYPE_p_PcpDependencyVector(UsdCsPINVOKE.PcpCache_FindSiteDependencies__SWIG_0(swigCPtr, PcpLayerStackPtr.getCPtr(siteLayerStack), SdfPath.getCPtr(sitePath), SWIGTYPE_p_PcpDependencyFlags.getCPtr(depMask), recurseOnSite, recurseOnIndex, filterForExistingCachesOnly), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_PcpDependencyVector FindSiteDependencies(SdfLayerHandle siteLayer, SdfPath sitePath, SWIGTYPE_p_PcpDependencyFlags depMask, bool recurseOnSite, bool recurseOnIndex, bool filterForExistingCachesOnly) {
    SWIGTYPE_p_PcpDependencyVector ret = new SWIGTYPE_p_PcpDependencyVector(UsdCsPINVOKE.PcpCache_FindSiteDependencies__SWIG_1(swigCPtr, SdfLayerHandle.getCPtr(siteLayer), SdfPath.getCPtr(sitePath), SWIGTYPE_p_PcpDependencyFlags.getCPtr(depMask), recurseOnSite, recurseOnIndex, filterForExistingCachesOnly), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CanHaveOpinionForSite(SdfPath localPcpSitePath, SdfLayerHandle layer, SdfPath allowedPathInLayer) {
    bool ret = UsdCsPINVOKE.PcpCache_CanHaveOpinionForSite(swigCPtr, SdfPath.getCPtr(localPcpSitePath), SdfLayerHandle.getCPtr(layer), SdfPath.getCPtr(allowedPathInLayer));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StdStringVector GetInvalidSublayerIdentifiers() {
    StdStringVector ret = new StdStringVector(UsdCsPINVOKE.PcpCache_GetInvalidSublayerIdentifiers(swigCPtr), true);
    return ret;
  }

  public bool IsInvalidSublayerIdentifier(string identifier) {
    bool ret = UsdCsPINVOKE.PcpCache_IsInvalidSublayerIdentifier(swigCPtr, identifier);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_SdfPath_std__vectorT_std__string_t_SdfPath__FastLessThan_t GetInvalidAssetPaths() {
    SWIGTYPE_p_std__mapT_SdfPath_std__vectorT_std__string_t_SdfPath__FastLessThan_t ret = new SWIGTYPE_p_std__mapT_SdfPath_std__vectorT_std__string_t_SdfPath__FastLessThan_t(UsdCsPINVOKE.PcpCache_GetInvalidAssetPaths(swigCPtr), true);
    return ret;
  }

  public bool IsInvalidAssetPath(string resolvedAssetPath) {
    bool ret = UsdCsPINVOKE.PcpCache_IsInvalidAssetPath(swigCPtr, resolvedAssetPath);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasAnyDynamicFileFormatArgumentDependencies() {
    bool ret = UsdCsPINVOKE.PcpCache_HasAnyDynamicFileFormatArgumentDependencies(swigCPtr);
    return ret;
  }

  public bool IsPossibleDynamicFileFormatArgumentField(TfToken field) {
    bool ret = UsdCsPINVOKE.PcpCache_IsPossibleDynamicFileFormatArgumentField(swigCPtr, TfToken.getCPtr(field));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_PcpDynamicFileFormatDependencyData GetDynamicFileFormatArgumentDependencyData(SdfPath primIndexPath) {
    SWIGTYPE_p_PcpDynamicFileFormatDependencyData ret = new SWIGTYPE_p_PcpDynamicFileFormatDependencyData(UsdCsPINVOKE.PcpCache_GetDynamicFileFormatArgumentDependencyData(swigCPtr, SdfPath.getCPtr(primIndexPath)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Apply(SWIGTYPE_p_PcpCacheChanges changes, SWIGTYPE_p_PcpLifeboat lifeboat) {
    UsdCsPINVOKE.PcpCache_Apply(swigCPtr, SWIGTYPE_p_PcpCacheChanges.getCPtr(changes), SWIGTYPE_p_PcpLifeboat.getCPtr(lifeboat));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reload(SWIGTYPE_p_PcpChanges changes) {
    UsdCsPINVOKE.PcpCache_Reload(swigCPtr, SWIGTYPE_p_PcpChanges.getCPtr(changes));
  }

  public void ReloadReferences(SWIGTYPE_p_PcpChanges changes, SdfPath primPath) {
    UsdCsPINVOKE.PcpCache_ReloadReferences(swigCPtr, SWIGTYPE_p_PcpChanges.getCPtr(changes), SdfPath.getCPtr(primPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void PrintStatistics() {
    UsdCsPINVOKE.PcpCache_PrintStatistics(swigCPtr);
  }

}

}
