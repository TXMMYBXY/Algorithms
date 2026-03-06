namespace Structures.Queue;

public class QueueItem
{
    public int Value { get; set; }
    public QueueItem Next { get; set; }

    public QueueItem(int value)
    {
        Value = value;
    }
}