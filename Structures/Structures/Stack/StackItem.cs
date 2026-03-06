namespace Structures.Stack;

public class StackItem
{
    public int Value { get; set; }
    public StackItem Next { get; set; }
    
    public StackItem(int value)
    {
        Value = value;
    }
}