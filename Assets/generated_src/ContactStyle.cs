/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ContactStyle : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ContactStyle(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ContactStyle obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ContactStyle() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_ContactStyle(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public bool admin {
    set {
      yarpPINVOKE.ContactStyle_admin_set(swigCPtr, value);
    } 
    get {
      bool ret = yarpPINVOKE.ContactStyle_admin_get(swigCPtr);
      return ret;
    } 
  }

  public bool quiet {
    set {
      yarpPINVOKE.ContactStyle_quiet_set(swigCPtr, value);
    } 
    get {
      bool ret = yarpPINVOKE.ContactStyle_quiet_get(swigCPtr);
      return ret;
    } 
  }

  public double timeout {
    set {
      yarpPINVOKE.ContactStyle_timeout_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.ContactStyle_timeout_get(swigCPtr);
      return ret;
    } 
  }

  public ConstString carrier {
    set {
      yarpPINVOKE.ContactStyle_carrier_set(swigCPtr, ConstString.getCPtr(value));
    } 
    get {
      IntPtr cPtr = yarpPINVOKE.ContactStyle_carrier_get(swigCPtr);
      ConstString ret = (cPtr == IntPtr.Zero) ? null : new ConstString(cPtr, false);
      return ret;
    } 
  }

  public bool expectReply {
    set {
      yarpPINVOKE.ContactStyle_expectReply_set(swigCPtr, value);
    } 
    get {
      bool ret = yarpPINVOKE.ContactStyle_expectReply_get(swigCPtr);
      return ret;
    } 
  }

  public bool persistent {
    set {
      yarpPINVOKE.ContactStyle_persistent_set(swigCPtr, value);
    } 
    get {
      bool ret = yarpPINVOKE.ContactStyle_persistent_get(swigCPtr);
      return ret;
    } 
  }

  public ContactStyle.PersistenceType persistenceType {
    set {
      yarpPINVOKE.ContactStyle_persistenceType_set(swigCPtr, (int)value);
    } 
    get {
      ContactStyle.PersistenceType ret = (ContactStyle.PersistenceType)yarpPINVOKE.ContactStyle_persistenceType_get(swigCPtr);
      return ret;
    } 
  }

  public ContactStyle() : this(yarpPINVOKE.new_ContactStyle(), true) {
  }

  public enum PersistenceType {
    OPENENDED = 0,
    END_WITH_FROM_PORT = 1,
    END_WITH_TO_PORT = 2,
    NO_PERSISTENCE = 3
  }

}
