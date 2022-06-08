//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class SdfLayerRefPtrSet : global::System.IDisposable, global::System.Collections.Generic.ISet<SdfLayer>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SdfLayerRefPtrSet(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfLayerRefPtrSet obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SdfLayerRefPtrSet() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_SdfLayerRefPtrSet(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  void global::System.Collections.Generic.ICollection<SdfLayer>.Add(SdfLayer item) {
      ((global::System.Collections.Generic.ISet<SdfLayer>)this).Add(item);
  }

  public bool TryGetValue(SdfLayer equalValue, out SdfLayer actualValue) {
    try {
      actualValue = getitem(equalValue);
      return true;
    } catch {
      actualValue = default(SdfLayer);
      return false;
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public void CopyTo(SdfLayer[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo(SdfLayer[] array, int arrayIndex) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");

    foreach (SdfLayer item in this) {
      array.SetValue(item, arrayIndex++);
    }
  }

  public void ExceptWith(global::System.Collections.Generic.IEnumerable<SdfLayer> other) {
    foreach (SdfLayer item in other) {
      Remove(item);
    }
  }

  public void IntersectWith(global::System.Collections.Generic.IEnumerable<SdfLayer> other) {
    SdfLayerRefPtrSet old = new SdfLayerRefPtrSet(this);

    Clear();
    foreach (SdfLayer item in other) {
      if (old.Contains(item))
        Add(item);
    }
  }

  private static int count_enum(global::System.Collections.Generic.IEnumerable<SdfLayer> other) {
    int count = 0;
    foreach (SdfLayer item in other) {
      count++;
    }

    return count;
  }

  public bool IsProperSubsetOf(global::System.Collections.Generic.IEnumerable<SdfLayer> other) {
    return IsSubsetOf(other) && Count < count_enum(other);
  }

  public bool IsProperSupersetOf(global::System.Collections.Generic.IEnumerable<SdfLayer> other) {
    return IsSupersetOf(other) && Count > count_enum(other);
  }

  public bool IsSubsetOf(global::System.Collections.Generic.IEnumerable<SdfLayer> other) {
    int countContained = 0;

    foreach (SdfLayer item in other) {
      if (Contains(item))
        countContained++;
    }

    return countContained == Count;
  }

  public bool IsSupersetOf(global::System.Collections.Generic.IEnumerable<SdfLayer> other) {
    foreach (SdfLayer item in other) {
      if (!Contains(item))
        return false;
    }

    return true;
  }

  public bool Overlaps(global::System.Collections.Generic.IEnumerable<SdfLayer> other) {
    foreach (SdfLayer item in other) {
      if (Contains(item))
        return true;
    }

    return false;
  }

  public bool SetEquals(global::System.Collections.Generic.IEnumerable<SdfLayer> other) {
    return IsSupersetOf(other) && Count == count_enum(other);
  }

  public void SymmetricExceptWith(global::System.Collections.Generic.IEnumerable<SdfLayer> other) {
    foreach (SdfLayer item in other) {
      if (!Remove(item))
        Add(item);
    }
  }

  public void UnionWith(global::System.Collections.Generic.IEnumerable<SdfLayer> other) {
    foreach (SdfLayer item in other) {
      Add(item);
    }
  }

  private global::System.Collections.Generic.ICollection<SdfLayer> Items {
    get {
      global::System.Collections.Generic.ICollection<SdfLayer> items = new global::System.Collections.Generic.List<SdfLayer>();
      int size = this.Count;
      if (size > 0) {
        global::System.IntPtr iter = create_iterator_begin();
        for (int i = 0; i < size; i++) {
          items.Add(get_next(iter));
        }
        destroy_iterator(iter);
      }
      return items;
    }
  }

  global::System.Collections.Generic.IEnumerator<SdfLayer> global::System.Collections.Generic.IEnumerable<SdfLayer>.GetEnumerator() {
    return new SdfLayerRefPtrSetEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new SdfLayerRefPtrSetEnumerator(this);
  }

  public SdfLayerRefPtrSetEnumerator GetEnumerator() {
    return new SdfLayerRefPtrSetEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class SdfLayerRefPtrSetEnumerator : global::System.Collections.IEnumerator,
      global::System.Collections.Generic.IEnumerator<SdfLayer>
  {
    private SdfLayerRefPtrSet collectionRef;
    private global::System.Collections.Generic.IList<SdfLayer> ItemsCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public SdfLayerRefPtrSetEnumerator(SdfLayerRefPtrSet collection) {
      collectionRef = collection;
      ItemsCollection = new global::System.Collections.Generic.List<SdfLayer>(collection.Items);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public SdfLayer Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (SdfLayer)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = ItemsCollection[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
      currentIndex = -1;
      currentObject = null;
    }
  }


  public SdfLayerRefPtrSet() : this(UsdCsPINVOKE.new_SdfLayerRefPtrSet__SWIG_0(), true) {
  }

  public SdfLayerRefPtrSet(SdfLayerRefPtrSet other) : this(UsdCsPINVOKE.new_SdfLayerRefPtrSet__SWIG_1(SdfLayerRefPtrSet.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = UsdCsPINVOKE.SdfLayerRefPtrSet_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = UsdCsPINVOKE.SdfLayerRefPtrSet_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    UsdCsPINVOKE.SdfLayerRefPtrSet_Clear(swigCPtr);
  }

  public bool Add(SdfLayer item) {
    bool ret = UsdCsPINVOKE.SdfLayerRefPtrSet_Add(swigCPtr, SdfLayer.getCPtr(item));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Contains(SdfLayer item) {
    bool ret = UsdCsPINVOKE.SdfLayerRefPtrSet_Contains(swigCPtr, SdfLayer.getCPtr(item));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(SdfLayer item) {
    bool ret = UsdCsPINVOKE.SdfLayerRefPtrSet_Remove(swigCPtr, SdfLayer.getCPtr(item));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private SdfLayer getitem(SdfLayer item) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdfLayerRefPtrSet_getitem(swigCPtr, SdfLayer.getCPtr(item));
    SdfLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayer(cPtr, true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private global::System.IntPtr create_iterator_begin() {
    global::System.IntPtr ret = UsdCsPINVOKE.SdfLayerRefPtrSet_create_iterator_begin(swigCPtr);
    return ret;
  }

  private SdfLayer get_next(global::System.IntPtr swigiterator) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdfLayerRefPtrSet_get_next(swigCPtr, swigiterator);
    SdfLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfLayer(cPtr, true);
    return ret;
  }

  private void destroy_iterator(global::System.IntPtr swigiterator) {
    UsdCsPINVOKE.SdfLayerRefPtrSet_destroy_iterator(swigCPtr, swigiterator);
  }

}

}