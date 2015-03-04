/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class TypedReaderImageRgb : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TypedReaderImageRgb(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TypedReaderImageRgb obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TypedReaderImageRgb() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_TypedReaderImageRgb(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public new void setStrict(bool strict) {
    yarpPINVOKE.TypedReaderImageRgb_setStrict__SWIG_0(swigCPtr, strict);
  }

  public new void setStrict() {
    yarpPINVOKE.TypedReaderImageRgb_setStrict__SWIG_1(swigCPtr);
  }

  public new ImageRgb read(bool shouldWait) {
    IntPtr cPtr = yarpPINVOKE.TypedReaderImageRgb_read__SWIG_0(swigCPtr, shouldWait);
    ImageRgb ret = (cPtr == IntPtr.Zero) ? null : new ImageRgb(cPtr, false);
    return ret;
  }

  public new ImageRgb read() {
    IntPtr cPtr = yarpPINVOKE.TypedReaderImageRgb_read__SWIG_1(swigCPtr);
    ImageRgb ret = (cPtr == IntPtr.Zero) ? null : new ImageRgb(cPtr, false);
    return ret;
  }

  public virtual void interrupt() {
    yarpPINVOKE.TypedReaderImageRgb_interrupt(swigCPtr);
  }

  public new ImageRgb lastRead() {
    IntPtr cPtr = yarpPINVOKE.TypedReaderImageRgb_lastRead(swigCPtr);
    ImageRgb ret = (cPtr == IntPtr.Zero) ? null : new ImageRgb(cPtr, false);
    return ret;
  }

  public new bool isClosed() {
    bool ret = yarpPINVOKE.TypedReaderImageRgb_isClosed(swigCPtr);
    return ret;
  }

  public new void useCallback(TypedReaderCallbackImageRgb callback) {
    yarpPINVOKE.TypedReaderImageRgb_useCallback(swigCPtr, TypedReaderCallbackImageRgb.getCPtr(callback));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void disableCallback() {
    yarpPINVOKE.TypedReaderImageRgb_disableCallback(swigCPtr);
  }

  public new int getPendingReads() {
    int ret = yarpPINVOKE.TypedReaderImageRgb_getPendingReads(swigCPtr);
    return ret;
  }

  public virtual ConstString getName() {
    ConstString ret = new ConstString(yarpPINVOKE.TypedReaderImageRgb_getName(swigCPtr), true);
    return ret;
  }

  public new void setReplier(PortReader reader) {
    yarpPINVOKE.TypedReaderImageRgb_setReplier(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_void acquire() {
    IntPtr cPtr = yarpPINVOKE.TypedReaderImageRgb_acquire(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public virtual void release(SWIGTYPE_p_void handle) {
    yarpPINVOKE.TypedReaderImageRgb_release(swigCPtr, SWIGTYPE_p_void.getCPtr(handle));
  }

  public new void setTargetPeriod(double period) {
    yarpPINVOKE.TypedReaderImageRgb_setTargetPeriod(swigCPtr, period);
  }

}
