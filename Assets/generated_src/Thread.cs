/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Thread : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Thread(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Thread obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Thread() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_Thread(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual void run() {
    yarpPINVOKE.Thread_run(swigCPtr);
  }

  public virtual void onStop() {
    yarpPINVOKE.Thread_onStop(swigCPtr);
  }

  public bool start() {
    bool ret = yarpPINVOKE.Thread_start(swigCPtr);
    return ret;
  }

  public bool stop() {
    bool ret = yarpPINVOKE.Thread_stop(swigCPtr);
    return ret;
  }

  public virtual void beforeStart() {
    yarpPINVOKE.Thread_beforeStart(swigCPtr);
  }

  public virtual void afterStart(bool success) {
    yarpPINVOKE.Thread_afterStart(swigCPtr, success);
  }

  public virtual bool threadInit() {
    bool ret = yarpPINVOKE.Thread_threadInit(swigCPtr);
    return ret;
  }

  public virtual void threadRelease() {
    yarpPINVOKE.Thread_threadRelease(swigCPtr);
  }

  public bool isStopping() {
    bool ret = yarpPINVOKE.Thread_isStopping(swigCPtr);
    return ret;
  }

  public bool isRunning() {
    bool ret = yarpPINVOKE.Thread_isRunning(swigCPtr);
    return ret;
  }

  public void setOptions(int stackSize) {
    yarpPINVOKE.Thread_setOptions__SWIG_0(swigCPtr, stackSize);
  }

  public void setOptions() {
    yarpPINVOKE.Thread_setOptions__SWIG_1(swigCPtr);
  }

  public static int getCount() {
    int ret = yarpPINVOKE.Thread_getCount();
    return ret;
  }

  public int getKey() {
    int ret = yarpPINVOKE.Thread_getKey(swigCPtr);
    return ret;
  }

  public int setPriority(int priority) {
    int ret = yarpPINVOKE.Thread_setPriority(swigCPtr, priority);
    return ret;
  }

  public int getPriority() {
    int ret = yarpPINVOKE.Thread_getPriority(swigCPtr);
    return ret;
  }

  public static void setDefaultStackSize(int stackSize) {
    yarpPINVOKE.Thread_setDefaultStackSize(stackSize);
  }

  public bool join(double seconds) {
    bool ret = yarpPINVOKE.Thread_join__SWIG_0(swigCPtr, seconds);
    return ret;
  }

  public bool join() {
    bool ret = yarpPINVOKE.Thread_join__SWIG_1(swigCPtr);
    return ret;
  }

}