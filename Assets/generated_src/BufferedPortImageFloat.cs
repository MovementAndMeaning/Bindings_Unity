/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class BufferedPortImageFloat : Contactable {
  private HandleRef swigCPtr;

  internal BufferedPortImageFloat(IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.BufferedPortImageFloat_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BufferedPortImageFloat obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BufferedPortImageFloat() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_BufferedPortImageFloat(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public BufferedPortImageFloat() : this(yarpPINVOKE.new_BufferedPortImageFloat(), true) {
  }

  public override bool addOutput(string name) {
    bool ret = yarpPINVOKE.BufferedPortImageFloat_addOutput__SWIG_0(swigCPtr, name);
    return ret;
  }

  public override bool addOutput(string name, string carrier) {
    bool ret = yarpPINVOKE.BufferedPortImageFloat_addOutput__SWIG_1(swigCPtr, name, carrier);
    return ret;
  }

  public override bool addOutput(Contact contact) {
    bool ret = yarpPINVOKE.BufferedPortImageFloat_addOutput__SWIG_2(swigCPtr, Contact.getCPtr(contact));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void close() {
    yarpPINVOKE.BufferedPortImageFloat_close(swigCPtr);
  }

  public override void interrupt() {
    yarpPINVOKE.BufferedPortImageFloat_interrupt(swigCPtr);
  }

  public override void resume() {
    yarpPINVOKE.BufferedPortImageFloat_resume(swigCPtr);
  }

  public new int getPendingReads() {
    int ret = yarpPINVOKE.BufferedPortImageFloat_getPendingReads(swigCPtr);
    return ret;
  }

  public override Contact where() {
    Contact ret = new Contact(yarpPINVOKE.BufferedPortImageFloat_where(swigCPtr), true);
    return ret;
  }

  public override ConstString getName() {
    ConstString ret = new ConstString(yarpPINVOKE.BufferedPortImageFloat_getName(swigCPtr), true);
    return ret;
  }

  public ImageFloat prepare() {
    ImageFloat ret = new ImageFloat(yarpPINVOKE.BufferedPortImageFloat_prepare(swigCPtr), false);
    return ret;
  }

  public bool unprepare() {
    bool ret = yarpPINVOKE.BufferedPortImageFloat_unprepare(swigCPtr);
    return ret;
  }

  public new void write(bool forceStrict) {
    yarpPINVOKE.BufferedPortImageFloat_write__SWIG_0(swigCPtr, forceStrict);
  }

  public new void write() {
    yarpPINVOKE.BufferedPortImageFloat_write__SWIG_1(swigCPtr);
  }

  public void writeStrict() {
    yarpPINVOKE.BufferedPortImageFloat_writeStrict(swigCPtr);
  }

  public new void setStrict(bool strict) {
    yarpPINVOKE.BufferedPortImageFloat_setStrict__SWIG_0(swigCPtr, strict);
  }

  public new void setStrict() {
    yarpPINVOKE.BufferedPortImageFloat_setStrict__SWIG_1(swigCPtr);
  }

  public new ImageFloat read(bool shouldWait) {
    IntPtr cPtr = yarpPINVOKE.BufferedPortImageFloat_read__SWIG_0(swigCPtr, shouldWait);
    ImageFloat ret = (cPtr == IntPtr.Zero) ? null : new ImageFloat(cPtr, false);
    return ret;
  }

  public new ImageFloat read() {
    IntPtr cPtr = yarpPINVOKE.BufferedPortImageFloat_read__SWIG_1(swigCPtr);
    ImageFloat ret = (cPtr == IntPtr.Zero) ? null : new ImageFloat(cPtr, false);
    return ret;
  }

  public new ImageFloat lastRead() {
    IntPtr cPtr = yarpPINVOKE.BufferedPortImageFloat_lastRead(swigCPtr);
    ImageFloat ret = (cPtr == IntPtr.Zero) ? null : new ImageFloat(cPtr, false);
    return ret;
  }

  public new bool isClosed() {
    bool ret = yarpPINVOKE.BufferedPortImageFloat_isClosed(swigCPtr);
    return ret;
  }

  public new void setReplier(PortReader reader) {
    yarpPINVOKE.BufferedPortImageFloat_setReplier(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setReader(PortReader reader) {
    yarpPINVOKE.BufferedPortImageFloat_setReader(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void onRead(ImageFloat datum) {
    yarpPINVOKE.BufferedPortImageFloat_onRead(swigCPtr, ImageFloat.getCPtr(datum));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void useCallback(TypedReaderCallbackImageFloat callback) {
    yarpPINVOKE.BufferedPortImageFloat_useCallback__SWIG_0(swigCPtr, TypedReaderCallbackImageFloat.getCPtr(callback));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void useCallback() {
    yarpPINVOKE.BufferedPortImageFloat_useCallback__SWIG_1(swigCPtr);
  }

  public virtual void disableCallback() {
    yarpPINVOKE.BufferedPortImageFloat_disableCallback(swigCPtr);
  }

  public override bool setEnvelope(PortWriter envelope) {
    bool ret = yarpPINVOKE.BufferedPortImageFloat_setEnvelope(swigCPtr, PortWriter.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool getEnvelope(PortReader envelope) {
    bool ret = yarpPINVOKE.BufferedPortImageFloat_getEnvelope(swigCPtr, PortReader.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getInputCount() {
    int ret = yarpPINVOKE.BufferedPortImageFloat_getInputCount(swigCPtr);
    return ret;
  }

  public override int getOutputCount() {
    int ret = yarpPINVOKE.BufferedPortImageFloat_getOutputCount(swigCPtr);
    return ret;
  }

  public override bool isWriting() {
    bool ret = yarpPINVOKE.BufferedPortImageFloat_isWriting(swigCPtr);
    return ret;
  }

  public override void getReport(PortReport reporter) {
    yarpPINVOKE.BufferedPortImageFloat_getReport(swigCPtr, PortReport.getCPtr(reporter));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setReporter(PortReport reporter) {
    yarpPINVOKE.BufferedPortImageFloat_setReporter(swigCPtr, PortReport.getCPtr(reporter));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_void acquire() {
    IntPtr cPtr = yarpPINVOKE.BufferedPortImageFloat_acquire(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public virtual void release(SWIGTYPE_p_void handle) {
    yarpPINVOKE.BufferedPortImageFloat_release(swigCPtr, SWIGTYPE_p_void.getCPtr(handle));
  }

  public new void setTargetPeriod(double period) {
    yarpPINVOKE.BufferedPortImageFloat_setTargetPeriod(swigCPtr, period);
  }

}