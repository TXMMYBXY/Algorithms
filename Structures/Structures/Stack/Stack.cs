namespace Structures.Stack;

public class Stack
{
    private StackItem _top;
    
    public void Push(int value)
    {
        var item = new StackItem(value);
        
        if (_top == null)
        {
            _top = item;
        }
        else
        {
            item.Next = _top;
            _top = item;
        }
    }
    
    public int Pop()
    {
        if(_top == null)
        {
            throw new InvalidOperationException();
        }
        
        var value = _top.Value;
        
        _top = _top.Next;

        return value;
    }
}