//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr
{
    public class UsdRiPxrIntMultLightFilter : UsdLuxLightFilter
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal UsdRiPxrIntMultLightFilter(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdRiPxrIntMultLightFilter_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdRiPxrIntMultLightFilter obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdRiPxrIntMultLightFilter()
        {
            Dispose();
        }

        public override void Dispose()
        {
            lock (this) {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        UsdCsPINVOKE.delete_UsdRiPxrIntMultLightFilter(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public UsdRiPxrIntMultLightFilter(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdRiPxrIntMultLightFilter__SWIG_0(UsdPrim.getCPtr(prim)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public UsdRiPxrIntMultLightFilter() : this(UsdCsPINVOKE.new_UsdRiPxrIntMultLightFilter__SWIG_1(), true)
        {
        }

        public UsdRiPxrIntMultLightFilter(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdRiPxrIntMultLightFilter__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiPxrIntMultLightFilter_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
            return ret;
        }

        public new static TfTokenVector GetSchemaAttributeNames()
        {
            TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiPxrIntMultLightFilter_GetSchemaAttributeNames__SWIG_1(), false);
            return ret;
        }

        public new static UsdRiPxrIntMultLightFilter Get(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdRiPxrIntMultLightFilter ret = new UsdRiPxrIntMultLightFilter(UsdCsPINVOKE.UsdRiPxrIntMultLightFilter_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public new static UsdRiPxrIntMultLightFilter Define(UsdStageWeakPtr stage, SdfPath path)
        {
            UsdRiPxrIntMultLightFilter ret = new UsdRiPxrIntMultLightFilter(UsdCsPINVOKE.UsdRiPxrIntMultLightFilter_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute GetRiIntensityAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrIntMultLightFilter_GetRiIntensityAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateRiIntensityAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrIntMultLightFilter_CreateRiIntensityAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiIntensityAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrIntMultLightFilter_CreateRiIntensityAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateRiIntensityAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrIntMultLightFilter_CreateRiIntensityAttr__SWIG_2(swigCPtr), true);
            return ret;
        }

        public UsdAttribute GetColorSaturationAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrIntMultLightFilter_GetColorSaturationAttr(swigCPtr), true);
            return ret;
        }

        public UsdAttribute CreateColorSaturationAttr(VtValue defaultValue, bool writeSparsely)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrIntMultLightFilter_CreateColorSaturationAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateColorSaturationAttr(VtValue defaultValue)
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrIntMultLightFilter_CreateColorSaturationAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute CreateColorSaturationAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrIntMultLightFilter_CreateColorSaturationAttr__SWIG_2(swigCPtr), true);
            return ret;
        }
    }
}