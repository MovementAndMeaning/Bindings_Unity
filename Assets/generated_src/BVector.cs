/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class BVector : IDisposable, System.Collections.IEnumerable
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IList<bool>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BVector(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BVector obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_BVector(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public BVector(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (bool element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public bool this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array)
#else
  public void CopyTo(bool[] array)
#endif
  {
    CopyTo(0, array, 0, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array, int arrayIndex)
#else
  public void CopyTo(bool[] array, int arrayIndex)
#endif
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(int index, System.Array array, int arrayIndex, int count)
#else
  public void CopyTo(int index, bool[] array, int arrayIndex, int count)
#endif
  {
    if (array == null)
      throw new ArgumentNullException("array");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

#if !SWIG_DOTNET_1
  System.Collections.Generic.IEnumerator<bool> System.Collections.Generic.IEnumerable<bool>.GetEnumerator() {
    return new BVectorEnumerator(this);
  }
#endif

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new BVectorEnumerator(this);
  }

  public BVectorEnumerator GetEnumerator() {
    return new BVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class BVectorEnumerator : System.Collections.IEnumerator
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerator<bool>
#endif
  {
    private BVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public BVectorEnumerator(BVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public bool Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (bool)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }

#if !SWIG_DOTNET_1
    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
#endif
  }

  public void Clear() {
    yarpPINVOKE.BVector_Clear(swigCPtr);
  }

  public void Add(bool x) {
    yarpPINVOKE.BVector_Add(swigCPtr, x);
  }

  private uint size() {
    uint ret = yarpPINVOKE.BVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = yarpPINVOKE.BVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    yarpPINVOKE.BVector_reserve(swigCPtr, n);
  }

  public BVector() : this(yarpPINVOKE.new_BVector__SWIG_0(), true) {
  }

  public BVector(BVector other) : this(yarpPINVOKE.new_BVector__SWIG_1(BVector.getCPtr(other)), true) {
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public BVector(int capacity) : this(yarpPINVOKE.new_BVector__SWIG_2(capacity), true) {
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  private bool getitemcopy(int index) {
    bool ret = yarpPINVOKE.BVector_getitemcopy(swigCPtr, index);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool getitem(int index) {
    bool ret = yarpPINVOKE.BVector_getitem(swigCPtr, index);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, bool val) {
    yarpPINVOKE.BVector_setitem(swigCPtr, index, val);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(BVector values) {
    yarpPINVOKE.BVector_AddRange(swigCPtr, BVector.getCPtr(values));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public BVector GetRange(int index, int count) {
    IntPtr cPtr = yarpPINVOKE.BVector_GetRange(swigCPtr, index, count);
    BVector ret = (cPtr == IntPtr.Zero) ? null : new BVector(cPtr, true);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, bool x) {
    yarpPINVOKE.BVector_Insert(swigCPtr, index, x);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, BVector values) {
    yarpPINVOKE.BVector_InsertRange(swigCPtr, index, BVector.getCPtr(values));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    yarpPINVOKE.BVector_RemoveAt(swigCPtr, index);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    yarpPINVOKE.BVector_RemoveRange(swigCPtr, index, count);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static BVector Repeat(bool value, int count) {
    IntPtr cPtr = yarpPINVOKE.BVector_Repeat(value, count);
    BVector ret = (cPtr == IntPtr.Zero) ? null : new BVector(cPtr, true);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    yarpPINVOKE.BVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    yarpPINVOKE.BVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, BVector values) {
    yarpPINVOKE.BVector_SetRange(swigCPtr, index, BVector.getCPtr(values));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(bool value) {
    bool ret = yarpPINVOKE.BVector_Contains(swigCPtr, value);
    return ret;
  }

  public int IndexOf(bool value) {
    int ret = yarpPINVOKE.BVector_IndexOf(swigCPtr, value);
    return ret;
  }

  public int LastIndexOf(bool value) {
    int ret = yarpPINVOKE.BVector_LastIndexOf(swigCPtr, value);
    return ret;
  }

  public bool Remove(bool value) {
    bool ret = yarpPINVOKE.BVector_Remove(swigCPtr, value);
    return ret;
  }

}