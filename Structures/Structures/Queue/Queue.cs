namespace Structures.Queue;

public class Queue
{
    private QueueItem _head;
    private QueueItem _tail;

    public void Enqueue(int value)
    {
        var item = new QueueItem(value);

        if (_head == null)
        {
            _head = _tail = item;
        }
        else 
        {
            _tail.Next = item;
            _tail = item;
        }
    }

    public int Dequeue()
    {
        if (_head == null)
        {
            throw new InvalidOperationException();
        }
        
        var value = _head.Value;
        
        _head = _head.Next;

        if (_head == null)
        {
            _tail = null;
        }
        
        return value;
    }
}