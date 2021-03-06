/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class RpcClient : Contactable {
  private HandleRef swigCPtr;

  internal RpcClient(IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.RpcClient_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RpcClient obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RpcClient() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_RpcClient(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public RpcClient() : this(yarpPINVOKE.new_RpcClient(), true) {
  }

  public override bool addOutput(string name) {
    bool ret = yarpPINVOKE.RpcClient_addOutput__SWIG_0(swigCPtr, name);
    return ret;
  }

  public override bool addOutput(string name, string carrier) {
    bool ret = yarpPINVOKE.RpcClient_addOutput__SWIG_1(swigCPtr, name, carrier);
    return ret;
  }

  public override bool addOutput(Contact contact) {
    bool ret = yarpPINVOKE.RpcClient_addOutput__SWIG_2(swigCPtr, Contact.getCPtr(contact));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void close() {
    yarpPINVOKE.RpcClient_close(swigCPtr);
  }

  public override void interrupt() {
    yarpPINVOKE.RpcClient_interrupt(swigCPtr);
  }

  public override void resume() {
    yarpPINVOKE.RpcClient_resume(swigCPtr);
  }

  public override Contact where() {
    Contact ret = new Contact(yarpPINVOKE.RpcClient_where(swigCPtr), true);
    return ret;
  }

  public override ConstString getName() {
    ConstString ret = new ConstString(yarpPINVOKE.RpcClient_getName(swigCPtr), true);
    return ret;
  }

  public new bool write(PortWriter writer, PortReader reader) {
    bool ret = yarpPINVOKE.RpcClient_write(swigCPtr, PortWriter.getCPtr(writer), PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool setEnvelope(PortWriter envelope) {
    bool ret = yarpPINVOKE.RpcClient_setEnvelope(swigCPtr, PortWriter.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool getEnvelope(PortReader envelope) {
    bool ret = yarpPINVOKE.RpcClient_getEnvelope(swigCPtr, PortReader.getCPtr(envelope));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getInputCount() {
    int ret = yarpPINVOKE.RpcClient_getInputCount(swigCPtr);
    return ret;
  }

  public override int getOutputCount() {
    int ret = yarpPINVOKE.RpcClient_getOutputCount(swigCPtr);
    return ret;
  }

  public override void getReport(PortReport reporter) {
    yarpPINVOKE.RpcClient_getReport(swigCPtr, PortReport.getCPtr(reporter));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setReporter(PortReport reporter) {
    yarpPINVOKE.RpcClient_setReporter(swigCPtr, PortReport.getCPtr(reporter));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool isWriting() {
    bool ret = yarpPINVOKE.RpcClient_isWriting(swigCPtr);
    return ret;
  }

  public override void setReader(PortReader reader) {
    yarpPINVOKE.RpcClient_setReader(swigCPtr, PortReader.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

}
