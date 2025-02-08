public class Stack<T>
{
    private List<T> _elements = new List<T>();

    public void Push(T item)
    {
        _elements.Add(item);
    }

    public T Pop()
    {
        if (_elements.Count == 0)
            throw new  InvalidOperationException("Stack is empty");
        var item = _elements[^1];
        _elements.RemoveAt(_elements.Count - 1);

        return item;
    }
}