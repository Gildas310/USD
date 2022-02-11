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

public class PcpLayerStack : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal PcpLayerStack(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PcpLayerStack obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PcpLayerStack() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          UsdCsPINVOKE.delete_PcpLayerStack(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public PcpLayerStackIdentifier GetIdentifier() {
    PcpLayerStackIdentifier ret = new PcpLayerStackIdentifier(UsdCsPINVOKE.PcpLayerStack_GetIdentifier(swigCPtr), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfLayerRefPtrVector GetLayers() {
    SdfLayerRefPtrVector ret = new SdfLayerRefPtrVector(UsdCsPINVOKE.PcpLayerStack_GetLayers(swigCPtr), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfLayerHandleVector GetSessionLayers() {
    SdfLayerHandleVector ret = new SdfLayerHandleVector(UsdCsPINVOKE.PcpLayerStack_GetSessionLayers(swigCPtr), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfLayerTreeHandle GetLayerTree() {
    SdfLayerTreeHandle ret = new SdfLayerTreeHandle(UsdCsPINVOKE.PcpLayerStack_GetLayerTree(swigCPtr), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfLayerOffset GetLayerOffsetForLayer(SdfLayerHandle arg0) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.PcpLayerStack_GetLayerOffsetForLayer__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(arg0));
    SdfLayerOffset ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayerOffset(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfLayerOffset GetLayerOffsetForLayer(SdfLayer arg0) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.PcpLayerStack_GetLayerOffsetForLayer__SWIG_1(swigCPtr, SdfLayer.getCPtr(arg0));
    SdfLayerOffset ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayerOffset(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfLayerOffset GetLayerOffsetForLayer(uint layerIdx) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.PcpLayerStack_GetLayerOffsetForLayer__SWIG_2(swigCPtr, layerIdx);
    SdfLayerOffset ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayerOffset(cPtr, false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StdStringSet GetMutedLayers() {
    StdStringSet ret = new StdStringSet(UsdCsPINVOKE.PcpLayerStack_GetMutedLayers(swigCPtr), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_PcpErrorVector GetLocalErrors() {
    SWIGTYPE_p_PcpErrorVector ret = new SWIGTYPE_p_PcpErrorVector(UsdCsPINVOKE.PcpLayerStack_GetLocalErrors(swigCPtr), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasLayer(SdfLayerHandle layer) {
    bool ret = UsdCsPINVOKE.PcpLayerStack_HasLayer__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(layer));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasLayer(SdfLayer layer) {
    bool ret = UsdCsPINVOKE.PcpLayerStack_HasLayer__SWIG_1(swigCPtr, SdfLayer.getCPtr(layer));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetTimeCodesPerSecond() {
    double ret = UsdCsPINVOKE.PcpLayerStack_GetTimeCodesPerSecond(swigCPtr);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t GetRelocatesSourceToTarget() {
    SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t ret = new SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t(UsdCsPINVOKE.PcpLayerStack_GetRelocatesSourceToTarget(swigCPtr), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t GetRelocatesTargetToSource() {
    SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t ret = new SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t(UsdCsPINVOKE.PcpLayerStack_GetRelocatesTargetToSource(swigCPtr), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t GetIncrementalRelocatesSourceToTarget() {
    SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t ret = new SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t(UsdCsPINVOKE.PcpLayerStack_GetIncrementalRelocatesSourceToTarget(swigCPtr), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t GetIncrementalRelocatesTargetToSource() {
    SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t ret = new SWIGTYPE_p_std__mapT_SdfPath_SdfPath_std__lessT_SdfPath_t_t(UsdCsPINVOKE.PcpLayerStack_GetIncrementalRelocatesTargetToSource(swigCPtr), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfPathVector GetPathsToPrimsWithRelocates() {
    SdfPathVector ret = new SdfPathVector(UsdCsPINVOKE.PcpLayerStack_GetPathsToPrimsWithRelocates(swigCPtr), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Apply(SWIGTYPE_p_PcpLayerStackChanges changes, SWIGTYPE_p_PcpLifeboat lifeboat) {
    UsdCsPINVOKE.PcpLayerStack_Apply(swigCPtr, SWIGTYPE_p_PcpLayerStackChanges.getCPtr(changes), SWIGTYPE_p_PcpLifeboat.getCPtr(lifeboat));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_PcpMapExpression GetExpressionForRelocatesAtPath(SdfPath path) {
    SWIGTYPE_p_PcpMapExpression ret = new SWIGTYPE_p_PcpMapExpression(UsdCsPINVOKE.PcpLayerStack_GetExpressionForRelocatesAtPath(swigCPtr, SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
