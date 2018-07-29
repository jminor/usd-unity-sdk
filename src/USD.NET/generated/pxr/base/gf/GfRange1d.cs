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

public class GfRange1d : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GfRange1d(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfRange1d obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GfRange1d() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_GfRange1d(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public void SetEmpty() {
    UsdCsPINVOKE.GfRange1d_SetEmpty(swigCPtr);
  }

  public GfRange1d() : this(UsdCsPINVOKE.new_GfRange1d__SWIG_0(), true) {
  }

  public GfRange1d(double min, double max) : this(UsdCsPINVOKE.new_GfRange1d__SWIG_1(min, max), true) {
  }

  public double GetMin() {
    double ret = UsdCsPINVOKE.GfRange1d_GetMin(swigCPtr);
    return ret;
  }

  public double GetMax() {
    double ret = UsdCsPINVOKE.GfRange1d_GetMax(swigCPtr);
    return ret;
  }

  public double GetSize() {
    double ret = UsdCsPINVOKE.GfRange1d_GetSize(swigCPtr);
    return ret;
  }

  public double GetMidpoint() {
    double ret = UsdCsPINVOKE.GfRange1d_GetMidpoint(swigCPtr);
    return ret;
  }

  public void SetMin(double min) {
    UsdCsPINVOKE.GfRange1d_SetMin(swigCPtr, min);
  }

  public void SetMax(double max) {
    UsdCsPINVOKE.GfRange1d_SetMax(swigCPtr, max);
  }

  public bool IsEmpty() {
    bool ret = UsdCsPINVOKE.GfRange1d_IsEmpty(swigCPtr);
    return ret;
  }

  public void ExtendBy(double point) {
    UsdCsPINVOKE.GfRange1d_ExtendBy__SWIG_0(swigCPtr, point);
  }

  public void ExtendBy(GfRange1d range) {
    UsdCsPINVOKE.GfRange1d_ExtendBy__SWIG_1(swigCPtr, GfRange1d.getCPtr(range));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(double point) {
    bool ret = UsdCsPINVOKE.GfRange1d_Contains__SWIG_0(swigCPtr, point);
    return ret;
  }

  public bool Contains(GfRange1d range) {
    bool ret = UsdCsPINVOKE.GfRange1d_Contains__SWIG_1(swigCPtr, GfRange1d.getCPtr(range));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsInside(double point) {
    bool ret = UsdCsPINVOKE.GfRange1d_IsInside__SWIG_0(swigCPtr, point);
    return ret;
  }

  public bool IsInside(GfRange1d range) {
    bool ret = UsdCsPINVOKE.GfRange1d_IsInside__SWIG_1(swigCPtr, GfRange1d.getCPtr(range));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsOutside(GfRange1d range) {
    bool ret = UsdCsPINVOKE.GfRange1d_IsOutside(swigCPtr, GfRange1d.getCPtr(range));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static GfRange1d GetUnion(GfRange1d a, GfRange1d b) {
    GfRange1d ret = new GfRange1d(UsdCsPINVOKE.GfRange1d_GetUnion(GfRange1d.getCPtr(a), GfRange1d.getCPtr(b)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfRange1d UnionWith(GfRange1d b) {
    GfRange1d ret = new GfRange1d(UsdCsPINVOKE.GfRange1d_UnionWith__SWIG_0(swigCPtr, GfRange1d.getCPtr(b)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfRange1d UnionWith(double b) {
    GfRange1d ret = new GfRange1d(UsdCsPINVOKE.GfRange1d_UnionWith__SWIG_1(swigCPtr, b), false);
    return ret;
  }

  public static GfRange1d Union(GfRange1d a, GfRange1d b) {
    GfRange1d ret = new GfRange1d(UsdCsPINVOKE.GfRange1d_Union__SWIG_0(GfRange1d.getCPtr(a), GfRange1d.getCPtr(b)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfRange1d Union(double b) {
    GfRange1d ret = new GfRange1d(UsdCsPINVOKE.GfRange1d_Union__SWIG_2(swigCPtr, b), false);
    return ret;
  }

  public static GfRange1d GetIntersection(GfRange1d a, GfRange1d b) {
    GfRange1d ret = new GfRange1d(UsdCsPINVOKE.GfRange1d_GetIntersection(GfRange1d.getCPtr(a), GfRange1d.getCPtr(b)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static GfRange1d Intersection(GfRange1d a, GfRange1d b) {
    GfRange1d ret = new GfRange1d(UsdCsPINVOKE.GfRange1d_Intersection__SWIG_0(GfRange1d.getCPtr(a), GfRange1d.getCPtr(b)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfRange1d IntersectWith(GfRange1d b) {
    GfRange1d ret = new GfRange1d(UsdCsPINVOKE.GfRange1d_IntersectWith(swigCPtr, GfRange1d.getCPtr(b)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetDistanceSquared(double p) {
    double ret = UsdCsPINVOKE.GfRange1d_GetDistanceSquared(swigCPtr, p);
    return ret;
  }

  public static bool Equals(GfRange1d lhs, GfRange1d rhs) {
    bool ret = UsdCsPINVOKE.GfRange1d_Equals(GfRange1d.getCPtr(lhs), GfRange1d.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = UsdCsPINVOKE.GfRange1d_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(GfRange1d lhs, GfRange1d rhs){
      // The Swig binding glue will re-enter this operator comparing to null, so 
      // that case must be handled explicitly to avoid an infinite loop. This is still
      // not great, since it crosses the C#/C++ barrier twice. A better approache might
      // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || GfRange1d.Equals(lhs, rhs));
    }

    public static bool operator !=(GfRange1d lhs, GfRange1d rhs) {
        return !(lhs == rhs);
    }

    override public bool Equals(object rhs) {
      return GfRange1d.Equals(this, rhs as GfRange1d);
    }
  
  public static readonly uint dimension = UsdCsPINVOKE.GfRange1d_dimension_get();
}

}
