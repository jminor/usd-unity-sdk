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

public class GfVec4i : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GfVec4i(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfVec4i obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GfVec4i() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_GfVec4i(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GfVec4i() : this(UsdCsPINVOKE.new_GfVec4i__SWIG_0(), true) {
  }

  public GfVec4i(GfVec4i other) : this(UsdCsPINVOKE.new_GfVec4i__SWIG_1(GfVec4i.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec4i(int value) : this(UsdCsPINVOKE.new_GfVec4i__SWIG_2(value), true) {
  }

  public GfVec4i(int s0, int s1, int s2, int s3) : this(UsdCsPINVOKE.new_GfVec4i__SWIG_3(s0, s1, s2, s3), true) {
  }

  public static GfVec4i XAxis() {
    GfVec4i ret = new GfVec4i(UsdCsPINVOKE.GfVec4i_XAxis(), true);
    return ret;
  }

  public static GfVec4i YAxis() {
    GfVec4i ret = new GfVec4i(UsdCsPINVOKE.GfVec4i_YAxis(), true);
    return ret;
  }

  public static GfVec4i ZAxis() {
    GfVec4i ret = new GfVec4i(UsdCsPINVOKE.GfVec4i_ZAxis(), true);
    return ret;
  }

  public static GfVec4i WAxis() {
    GfVec4i ret = new GfVec4i(UsdCsPINVOKE.GfVec4i_WAxis(), true);
    return ret;
  }

  public static GfVec4i Axis(uint i) {
    GfVec4i ret = new GfVec4i(UsdCsPINVOKE.GfVec4i_Axis(i), true);
    return ret;
  }

  public GfVec4i Set(int s0, int s1, int s2, int s3) {
    GfVec4i ret = new GfVec4i(UsdCsPINVOKE.GfVec4i_Set(swigCPtr, s0, s1, s2, s3), false);
    return ret;
  }

  public GfVec4i GetProjection(GfVec4i v) {
    GfVec4i ret = new GfVec4i(UsdCsPINVOKE.GfVec4i_GetProjection(swigCPtr, GfVec4i.getCPtr(v)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec4i GetComplement(GfVec4i b) {
    GfVec4i ret = new GfVec4i(UsdCsPINVOKE.GfVec4i_GetComplement(swigCPtr, GfVec4i.getCPtr(b)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetLengthSq() {
    int ret = UsdCsPINVOKE.GfVec4i_GetLengthSq(swigCPtr);
    return ret;
  }

  public static bool Equals(GfVec4i lhs, GfVec4i rhs) {
    bool ret = UsdCsPINVOKE.GfVec4i_Equals(GfVec4i.getCPtr(lhs), GfVec4i.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = UsdCsPINVOKE.GfVec4i_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(GfVec4i lhs, GfVec4i rhs){
      // The Swig binding glue will re-enter this operator comparing to null, so 
      // that case must be handled explicitly to avoid an infinite loop. This is still
      // not great, since it crosses the C#/C++ barrier twice. A better approache might
      // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || GfVec4i.Equals(lhs, rhs));
    }

    public static bool operator !=(GfVec4i lhs, GfVec4i rhs) {
        return !(lhs == rhs);
    }

    override public bool Equals(object rhs) {
      return GfVec4i.Equals(this, rhs as GfVec4i);
    }
  
  protected int GetValue(int index) {
    int ret = UsdCsPINVOKE.GfVec4i_GetValue(swigCPtr, index);
    return ret;
  }

  protected void SetValue(int index, int value) {
    UsdCsPINVOKE.GfVec4i_SetValue(swigCPtr, index, value);
  }

  public int this[int index] {
    get { return GetValue(index); }
    set { SetValue(index, value); }
  }
  
  public static readonly uint dimension = UsdCsPINVOKE.GfVec4i_dimension_get();
}

}
