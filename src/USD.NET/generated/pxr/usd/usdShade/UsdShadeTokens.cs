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

public class UsdShadeTokens : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdShadeTokens(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdShadeTokens obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static TfToken connectedSourceFor = new TfToken("connectedSourceFor:");
  public static TfToken derivesFrom = new TfToken("derivesFrom");
  public static TfToken displacement = new TfToken("displacement");
  public static TfToken full = new TfToken("full");
  public static TfToken infoId = new TfToken("info:id");
  public static TfToken inputs = new TfToken("inputs:");
  public static TfToken interfaceOnly = new TfToken("interfaceOnly");
  public static TfToken interfaceRecipientsOf = new TfToken("interfaceRecipientsOf:");
  public static TfToken interface_ = new TfToken("interface:");
  public static TfToken lookBinding = new TfToken("look:binding");
  public static TfToken materialBind = new TfToken("materialBind");
  public static TfToken materialBinding = new TfToken("material:binding");
  public static TfToken materialVariant = new TfToken("materialVariant");
  public static TfToken outputs = new TfToken("outputs:");
  public static TfToken surface = new TfToken("surface");

}

}
