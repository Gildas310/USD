//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class JsValue : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal JsValue(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JsValue obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~JsValue() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_JsValue(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public JsValue() : this(UsdCsPINVOKE.new_JsValue__SWIG_0(), true) {
  }

  public JsValue(JsObject value) : this(UsdCsPINVOKE.new_JsValue__SWIG_1(JsObject.getCPtr(value)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public JsValue(JsObjectVector value) : this(UsdCsPINVOKE.new_JsValue__SWIG_3(JsObjectVector.getCPtr(value)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public JsValue(string value) : this(UsdCsPINVOKE.new_JsValue__SWIG_5(value), true) {
  }

  public JsValue(SWIGTYPE_p_std__string value) : this(UsdCsPINVOKE.new_JsValue__SWIG_7(SWIGTYPE_p_std__string.getCPtr(value)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public JsValue(bool value) : this(UsdCsPINVOKE.new_JsValue__SWIG_8(value), true) {
  }

  public JsValue(int value) : this(UsdCsPINVOKE.new_JsValue__SWIG_9(value), true) {
  }

  public JsValue(long value) : this(UsdCsPINVOKE.new_JsValue__SWIG_10(value), true) {
  }

  public JsValue(ulong value) : this(UsdCsPINVOKE.new_JsValue__SWIG_11(value), true) {
  }

  public JsValue(double value) : this(UsdCsPINVOKE.new_JsValue__SWIG_12(value), true) {
  }

  public JsObject GetJsObject() {
    JsObject ret = new JsObject(UsdCsPINVOKE.JsValue_GetJsObject(swigCPtr), false);
    return ret;
  }

  public JsObjectVector GetJsArray() {
    JsObjectVector ret = new JsObjectVector(UsdCsPINVOKE.JsValue_GetJsArray(swigCPtr), false);
    return ret;
  }

  public string GetString() {
    string ret = UsdCsPINVOKE.JsValue_GetString(swigCPtr);
    return ret;
  }

  public bool GetBool() {
    bool ret = UsdCsPINVOKE.JsValue_GetBool(swigCPtr);
    return ret;
  }

  public int GetInt() {
    int ret = UsdCsPINVOKE.JsValue_GetInt(swigCPtr);
    return ret;
  }

  public long GetInt64() {
    long ret = UsdCsPINVOKE.JsValue_GetInt64(swigCPtr);
    return ret;
  }

  public ulong GetUInt64() {
    ulong ret = UsdCsPINVOKE.JsValue_GetUInt64(swigCPtr);
    return ret;
  }

  public double GetReal() {
    double ret = UsdCsPINVOKE.JsValue_GetReal(swigCPtr);
    return ret;
  }

  public JsValue.Type GetType() {
    JsValue.Type ret = (JsValue.Type)UsdCsPINVOKE.JsValue_GetType(swigCPtr);
    return ret;
  }

  public string GetTypeName() {
    string ret = UsdCsPINVOKE.JsValue_GetTypeName(swigCPtr);
    return ret;
  }

  public bool IsObject() {
    bool ret = UsdCsPINVOKE.JsValue_IsObject(swigCPtr);
    return ret;
  }

  public bool IsArray() {
    bool ret = UsdCsPINVOKE.JsValue_IsArray(swigCPtr);
    return ret;
  }

  public bool IsString() {
    bool ret = UsdCsPINVOKE.JsValue_IsString(swigCPtr);
    return ret;
  }

  public bool IsBool() {
    bool ret = UsdCsPINVOKE.JsValue_IsBool(swigCPtr);
    return ret;
  }

  public bool IsInt() {
    bool ret = UsdCsPINVOKE.JsValue_IsInt(swigCPtr);
    return ret;
  }

  public bool IsReal() {
    bool ret = UsdCsPINVOKE.JsValue_IsReal(swigCPtr);
    return ret;
  }

  public bool IsUInt64() {
    bool ret = UsdCsPINVOKE.JsValue_IsUInt64(swigCPtr);
    return ret;
  }

  public bool IsNull() {
    bool ret = UsdCsPINVOKE.JsValue_IsNull(swigCPtr);
    return ret;
  }

  public enum Type {
    ObjectType,
    ArrayType,
    StringType,
    BoolType,
    IntType,
    RealType,
    NullType
  }

}

}