using System.Collections;

namespace MyArrayLib;

public class MyArray<T> : IEnumerable<T>
{
    public MyArrayElement<T>[] myArray;
    public int Length { get; private set; }
    public MyArray(int length)
    {
        myArray = new MyArrayElement<T>[length];
        Length = length;
    }

    public void AddLast(MyArrayElement<T> item)
    {
        if (Length == 0)
        {
            myArray[0] = item;
            Length++;
            return;
        }

        MyArrayElement<T>[] newArray = new MyArrayElement<T>[Length + 1];
        for (int i = 0; i < Length; i++)
        {
            newArray[i] = myArray[i];
        }
        newArray[Length - 1] = item;
        myArray = newArray;
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        int index = 0;
        while (myArray[index] != null)
        {
            yield return myArray[index].Value;
            index++;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
