namespace MyArrayLib;

public class MyArrayElement<T>
{
    public T Value { get; set; }
    public int Index { get; set; }

    public MyArrayElement(T value, int index)
    {
        Value = value;
        Index = index;
    }
}
