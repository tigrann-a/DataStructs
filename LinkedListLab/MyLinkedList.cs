using System.Collections;

namespace LinkedListLab;

public class MyLinkedList<T> : ICollection<T>
{
    public MyLinkedListNode<T> Head { get; private set; }
    public MyLinkedListNode<T> Tail { get; private set; }

    #region ICollection
    public int Count { get; private set; }

    public bool IsReadOnly { get => false; }

    public void Add(T item)
    {
        AddLast(item);
    }

    public void Clear()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    public bool Contains(T item)
    {
        MyLinkedListNode<T> current = Head;
        while(current != null)
        {
            if(current.Value.Equals(item))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        if(array == null)
            throw new ArgumentNullException("array is null");
        if(arrayIndex < 0)
            throw new ArgumentOutOfRangeException("index is negative");
        if (array.Length - arrayIndex < Count)
            throw new IndexOutOfRangeException();

        MyLinkedListNode<T> current = Head;
        while(current != null)
        {
            array[arrayIndex] = current.Value;
            arrayIndex++;
            current = current.Next;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        MyLinkedListNode<T> current = Head;
        while(current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    #endregion

    #region Add

    public void AddFirst(T item)
    {
        AddFirst(new MyLinkedListNode<T>(item));
    }

    private void AddFirst(MyLinkedListNode<T> node)
    {
        MyLinkedListNode<T> temp = Head; // Temp = |3| -> 5
        Head = node; // Head = |1| -> Null
        Head.Next = temp; // Head = |1| -> |3|
        Count++;
        if (Count == 1)
            Tail = Head;
    }

    public void AddLast(T item)
    {
        AddLast(new MyLinkedListNode<T>(item));
    }

    private void AddLast(MyLinkedListNode<T> node)
    {
        if (Count == 0)
            Head = node;

        else
            Tail.Next = node;

        Tail = node;
        Count++;
    }

    #endregion

    #region Remove

    public void RemoveFirst(T item)
    {
        RemoveFirst();
    }

    private void RemoveFirst()
    {
        if(Head == null)
        {
            return
        }

        MyLinkedListNode<T> temp = Head;
        Head = Head.Next;
        temp.Next = null;
        Count--;
    }

    public void RemoveLast(T item)
    {
        RemoveLast();
    }

    private void RemoveLast()
    {
        if(Head == null)
        {
            return
        }
        if(Head.Next == null)
        {
            Head = null;
            Tail = null;
            return
        }

        MyLinkedListNode<T> current = Head;
        while( current.Next != Tail )
        {
            current = current.Next;
        }

        current.Next = null;
        Tail = current;
    }

    #endregion
}