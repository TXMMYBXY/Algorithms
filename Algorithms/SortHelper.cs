namespace Algorithms;

public class SortHelper
{
    public T[] MakeArray<T>(int length)
    {
        var rnd = new Random();

        var array = new T[length];

        for (int i = 0; i < array.Length; i++)
        {
            if (typeof(T) == typeof(char)) array.SetValue((char)rnd.Next(0, 50), i);
            else array.SetValue(rnd.Next(0, 50), i);
        }
        return array;
    }

    public T[] BubbleSortArray<T>(T[] array) where T : IComparable
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 1; j < array.Length - 1; j++)
            {
                if (array[i].CompareTo(array[j]) < 0)
                {
                    array = _Swap(array, i, j);
                }
            }
        }
        
        return array;
    }

    public T[] SelectionSortArray<T>(T[] array) where T : IComparable
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i].CompareTo(array[j]) > 0)
                {
                    array = _Swap(array, i, j);
                }
            }
        }
        
        return array;
    }

    public T[] InsertSortArray<T>(T[] array) where T : IComparable
    {
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = i; j > 0; j--)
            {
                if (array[j - 1].CompareTo(array[j]) < 0)
                {
                    break;
                }
                array = _Swap(array, j, j - 1);
            }
        }
        
        return array;
    }
    
    public T[] ShakeSortArray<T>(T[] array) where T : IComparable
    {
        int right = array.Length - 1;
        int left = 0;

        while (left <= right)
        {
            for(int i = left; i < right; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    array = _Swap(array, i, i + 1);
                }
            }
            right--;

            for(int j = right; j > left; j--)
            {
                if (array[j].CompareTo(array[j - 1]) < 0)
                {
                    array = _Swap(array, j, j - 1);
                }

            }
            left++;
        }
        return array;
    }

    public T[] BrushSortArray<T>(T[] array) where T : IComparable
    {
        const double ratio = 1.247;
        int step = array.Length;
        bool swaped = true;

        while (step > 1 || swaped)
        {
            step = (int)(step / ratio);

            if (step < 1)
            {
                step = 1;
            }
            
            swaped = false;

            for (int i = 0; i + step < array.Length; i++)
            {
                if (array[i].CompareTo(array[i + step]) > 0)
                {
                    array = _Swap(array, i, i + step);
                    swaped = true;
                }
            }
        }

        return array;
    }

    private T[] _Swap<T>(T[] array, int i, int j)
    {
        var temp = array.GetValue(j);
        
        array.SetValue(array.GetValue(i), j);
        array.SetValue(temp, i);
        
        return array;
    }
    
    public void WriteArray(Array array)
    {
        Console.WriteLine("Массив:");
        foreach (var element in array)
            Console.WriteLine(element.ToString());
    }
}