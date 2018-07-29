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

public class GfMatrix4d : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GfMatrix4d(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfMatrix4d obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GfMatrix4d() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_GfMatrix4d(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GfMatrix4d() : this(UsdCsPINVOKE.new_GfMatrix4d__SWIG_0(), true) {
  }

  public GfMatrix4d(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33) : this(UsdCsPINVOKE.new_GfMatrix4d__SWIG_1(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33), true) {
  }

  public GfMatrix4d(double s) : this(UsdCsPINVOKE.new_GfMatrix4d__SWIG_2(s), true) {
  }

  public GfMatrix4d(GfVec4d v) : this(UsdCsPINVOKE.new_GfMatrix4d__SWIG_3(GfVec4d.getCPtr(v)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfMatrix4d(StdDoubleVectorVector v) : this(UsdCsPINVOKE.new_GfMatrix4d__SWIG_4(StdDoubleVectorVector.getCPtr(v)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfMatrix4d(StdFloatVectorVector v) : this(UsdCsPINVOKE.new_GfMatrix4d__SWIG_5(StdFloatVectorVector.getCPtr(v)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfMatrix4d(StdDoubleVector r0, StdDoubleVector r1, StdDoubleVector r2, StdDoubleVector r3) : this(UsdCsPINVOKE.new_GfMatrix4d__SWIG_6(StdDoubleVector.getCPtr(r0), StdDoubleVector.getCPtr(r1), StdDoubleVector.getCPtr(r2), StdDoubleVector.getCPtr(r3)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfMatrix4d(StdFloatVector r0, StdFloatVector r1, StdFloatVector r2, StdFloatVector r3) : this(UsdCsPINVOKE.new_GfMatrix4d__SWIG_7(StdFloatVector.getCPtr(r0), StdFloatVector.getCPtr(r1), StdFloatVector.getCPtr(r2), StdFloatVector.getCPtr(r3)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfMatrix4d(GfRotation rotate, GfVec3d translate) : this(UsdCsPINVOKE.new_GfMatrix4d__SWIG_8(GfRotation.getCPtr(rotate), GfVec3d.getCPtr(translate)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfMatrix4d(GfMatrix3d rotmx, GfVec3d translate) : this(UsdCsPINVOKE.new_GfMatrix4d__SWIG_9(GfMatrix3d.getCPtr(rotmx), GfVec3d.getCPtr(translate)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfMatrix4d(GfMatrix4f m) : this(UsdCsPINVOKE.new_GfMatrix4d__SWIG_10(GfMatrix4f.getCPtr(m)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRow(int i, GfVec4d v) {
    UsdCsPINVOKE.GfMatrix4d_SetRow(swigCPtr, i, GfVec4d.getCPtr(v));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetColumn(int i, GfVec4d v) {
    UsdCsPINVOKE.GfMatrix4d_SetColumn(swigCPtr, i, GfVec4d.getCPtr(v));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec4d GetRow(int i) {
    GfVec4d ret = new GfVec4d(UsdCsPINVOKE.GfMatrix4d_GetRow(swigCPtr, i), true);
    return ret;
  }

  public GfVec4d GetColumn(int i) {
    GfVec4d ret = new GfVec4d(UsdCsPINVOKE.GfMatrix4d_GetColumn(swigCPtr, i), true);
    return ret;
  }

  public GfMatrix4d Set(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_Set(swigCPtr, m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33), false);
    return ret;
  }

  public GfMatrix4d SetIdentity() {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetIdentity(swigCPtr), false);
    return ret;
  }

  public GfMatrix4d SetZero() {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetZero(swigCPtr), false);
    return ret;
  }

  public GfMatrix4d SetDiagonal(double s) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetDiagonal__SWIG_0(swigCPtr, s), false);
    return ret;
  }

  public GfMatrix4d SetDiagonal(GfVec4d arg0) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetDiagonal__SWIG_1(swigCPtr, GfVec4d.getCPtr(arg0)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_double Get(SWIGTYPE_p_a_4__double m) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.GfMatrix4d_Get(swigCPtr, SWIGTYPE_p_a_4__double.getCPtr(m));
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    return ret;
  }

  public GfMatrix4d GetTranspose() {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_GetTranspose(swigCPtr), true);
    return ret;
  }

  public GfMatrix4d GetInverse(ref double det, double eps) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_GetInverse__SWIG_0(swigCPtr, ref det, eps), true);
    return ret;
  }

  public GfMatrix4d GetInverse(ref double det) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_GetInverse__SWIG_1(swigCPtr, ref det), true);
    return ret;
  }

  public GfMatrix4d GetInverse() {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_GetInverse__SWIG_2(swigCPtr), true);
    return ret;
  }

  public double GetDeterminant() {
    double ret = UsdCsPINVOKE.GfMatrix4d_GetDeterminant(swigCPtr);
    return ret;
  }

  public void SetRow3(int i, GfVec3d v) {
    UsdCsPINVOKE.GfMatrix4d_SetRow3(swigCPtr, i, GfVec3d.getCPtr(v));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec3d GetRow3(int i) {
    GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfMatrix4d_GetRow3(swigCPtr, i), true);
    return ret;
  }

  public double GetDeterminant3() {
    double ret = UsdCsPINVOKE.GfMatrix4d_GetDeterminant3(swigCPtr);
    return ret;
  }

  public bool HasOrthogonalRows3() {
    bool ret = UsdCsPINVOKE.GfMatrix4d_HasOrthogonalRows3(swigCPtr);
    return ret;
  }

  public bool Orthonormalize(bool issueWarning) {
    bool ret = UsdCsPINVOKE.GfMatrix4d_Orthonormalize__SWIG_0(swigCPtr, issueWarning);
    return ret;
  }

  public bool Orthonormalize() {
    bool ret = UsdCsPINVOKE.GfMatrix4d_Orthonormalize__SWIG_1(swigCPtr);
    return ret;
  }

  public GfMatrix4d GetOrthonormalized(bool issueWarning) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_GetOrthonormalized__SWIG_0(swigCPtr, issueWarning), true);
    return ret;
  }

  public GfMatrix4d GetOrthonormalized() {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_GetOrthonormalized__SWIG_1(swigCPtr), true);
    return ret;
  }

  public double GetHandedness() {
    double ret = UsdCsPINVOKE.GfMatrix4d_GetHandedness(swigCPtr);
    return ret;
  }

  public bool IsRightHanded() {
    bool ret = UsdCsPINVOKE.GfMatrix4d_IsRightHanded(swigCPtr);
    return ret;
  }

  public bool IsLeftHanded() {
    bool ret = UsdCsPINVOKE.GfMatrix4d_IsLeftHanded(swigCPtr);
    return ret;
  }

  public GfMatrix4d SetScale(double scaleFactor) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetScale__SWIG_0(swigCPtr, scaleFactor), false);
    return ret;
  }

  public GfMatrix4d RemoveScaleShear() {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_RemoveScaleShear(swigCPtr), true);
    return ret;
  }

  public GfMatrix4d SetRotate(GfQuatd rot) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetRotate__SWIG_0(swigCPtr, GfQuatd.getCPtr(rot)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d SetRotateOnly(GfQuatd rot) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetRotateOnly__SWIG_0(swigCPtr, GfQuatd.getCPtr(rot)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d SetRotate(GfRotation rot) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetRotate__SWIG_1(swigCPtr, GfRotation.getCPtr(rot)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d SetRotateOnly(GfRotation rot) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetRotateOnly__SWIG_1(swigCPtr, GfRotation.getCPtr(rot)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d SetRotate(GfMatrix3d mx) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetRotate__SWIG_2(swigCPtr, GfMatrix3d.getCPtr(mx)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d SetRotateOnly(GfMatrix3d mx) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetRotateOnly__SWIG_2(swigCPtr, GfMatrix3d.getCPtr(mx)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d SetScale(GfVec3d scaleFactors) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetScale__SWIG_1(swigCPtr, GfVec3d.getCPtr(scaleFactors)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d SetTranslate(GfVec3d trans) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetTranslate(swigCPtr, GfVec3d.getCPtr(trans)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d SetTranslateOnly(GfVec3d t) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetTranslateOnly(swigCPtr, GfVec3d.getCPtr(t)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d SetTransform(GfRotation rotate, GfVec3d translate) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetTransform__SWIG_0(swigCPtr, GfRotation.getCPtr(rotate), GfVec3d.getCPtr(translate)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d SetTransform(GfMatrix3d rotmx, GfVec3d translate) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetTransform__SWIG_1(swigCPtr, GfMatrix3d.getCPtr(rotmx), GfVec3d.getCPtr(translate)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d SetLookAt(GfVec3d eyePoint, GfVec3d centerPoint, GfVec3d upDirection) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetLookAt__SWIG_0(swigCPtr, GfVec3d.getCPtr(eyePoint), GfVec3d.getCPtr(centerPoint), GfVec3d.getCPtr(upDirection)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix4d SetLookAt(GfVec3d eyePoint, GfRotation orientation) {
    GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.GfMatrix4d_SetLookAt__SWIG_1(swigCPtr, GfVec3d.getCPtr(eyePoint), GfRotation.getCPtr(orientation)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Factor(GfMatrix4d r, GfVec3d s, GfMatrix4d u, GfVec3d t, GfMatrix4d p, double eps) {
    bool ret = UsdCsPINVOKE.GfMatrix4d_Factor__SWIG_0(swigCPtr, GfMatrix4d.getCPtr(r), GfVec3d.getCPtr(s), GfMatrix4d.getCPtr(u), GfVec3d.getCPtr(t), GfMatrix4d.getCPtr(p), eps);
    return ret;
  }

  public bool Factor(GfMatrix4d r, GfVec3d s, GfMatrix4d u, GfVec3d t, GfMatrix4d p) {
    bool ret = UsdCsPINVOKE.GfMatrix4d_Factor__SWIG_1(swigCPtr, GfMatrix4d.getCPtr(r), GfVec3d.getCPtr(s), GfMatrix4d.getCPtr(u), GfVec3d.getCPtr(t), GfMatrix4d.getCPtr(p));
    return ret;
  }

  public GfVec3d ExtractTranslation() {
    GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfMatrix4d_ExtractTranslation(swigCPtr), true);
    return ret;
  }

  public GfRotation ExtractRotation() {
    GfRotation ret = new GfRotation(UsdCsPINVOKE.GfMatrix4d_ExtractRotation(swigCPtr), true);
    return ret;
  }

  public GfVec3d DecomposeRotation(GfVec3d axis0, GfVec3d axis1, GfVec3d axis2) {
    GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfMatrix4d_DecomposeRotation(swigCPtr, GfVec3d.getCPtr(axis0), GfVec3d.getCPtr(axis1), GfVec3d.getCPtr(axis2)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfMatrix3d ExtractRotationMatrix() {
    GfMatrix3d ret = new GfMatrix3d(UsdCsPINVOKE.GfMatrix4d_ExtractRotationMatrix(swigCPtr), true);
    return ret;
  }

  public GfVec3d Transform(GfVec3d vec) {
    GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfMatrix4d_Transform__SWIG_0(swigCPtr, GfVec3d.getCPtr(vec)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec3f Transform(GfVec3f vec) {
    GfVec3f ret = new GfVec3f(UsdCsPINVOKE.GfMatrix4d_Transform__SWIG_1(swigCPtr, GfVec3f.getCPtr(vec)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec3d TransformDir(GfVec3d vec) {
    GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfMatrix4d_TransformDir__SWIG_0(swigCPtr, GfVec3d.getCPtr(vec)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec3f TransformDir(GfVec3f vec) {
    GfVec3f ret = new GfVec3f(UsdCsPINVOKE.GfMatrix4d_TransformDir__SWIG_1(swigCPtr, GfVec3f.getCPtr(vec)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec3d TransformAffine(GfVec3d vec) {
    GfVec3d ret = new GfVec3d(UsdCsPINVOKE.GfMatrix4d_TransformAffine__SWIG_0(swigCPtr, GfVec3d.getCPtr(vec)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec3f TransformAffine(GfVec3f vec) {
    GfVec3f ret = new GfVec3f(UsdCsPINVOKE.GfMatrix4d_TransformAffine__SWIG_1(swigCPtr, GfVec3f.getCPtr(vec)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(GfMatrix4d lhs, GfMatrix4d rhs) {
    bool ret = UsdCsPINVOKE.GfMatrix4d_Equals(GfMatrix4d.getCPtr(lhs), GfMatrix4d.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = UsdCsPINVOKE.GfMatrix4d_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(GfMatrix4d lhs, GfMatrix4d rhs){
      // The Swig binding glue will re-enter this operator comparing to null, so 
      // that case must be handled explicitly to avoid an infinite loop. This is still
      // not great, since it crosses the C#/C++ barrier twice. A better approache might
      // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || GfMatrix4d.Equals(lhs, rhs));
    }

    public static bool operator !=(GfMatrix4d lhs, GfMatrix4d rhs) {
        return !(lhs == rhs);
    }

    override public bool Equals(object rhs) {
      return GfMatrix4d.Equals(this, rhs as GfMatrix4d);
    }
  
  public override string ToString() {
    string ret = UsdCsPINVOKE.GfMatrix4d_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(double[] dest) {
    UsdCsPINVOKE.GfMatrix4d_CopyToArray(swigCPtr, dest);
  }

  public void CopyFromArray(double[] src) {
    UsdCsPINVOKE.GfMatrix4d_CopyFromArray(swigCPtr, src);
  }

  public static readonly uint numRows = UsdCsPINVOKE.GfMatrix4d_numRows_get();
  public static readonly uint numColumns = UsdCsPINVOKE.GfMatrix4d_numColumns_get();
}

}
