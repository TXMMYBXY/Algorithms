namespace Algorithms.SlideWindow;

public class SlideWindowHelper
{
    public int MaxSum(int[] array, int k)
    {
        var windowSum = 0;

        for (int i = 0; i < k; i++)
        {
            windowSum += array[i];
        }

        var maxSum = windowSum;

        for (int r = k; r < array.Length; r++)
        {
            var l = r - k;

            windowSum = windowSum - array[l] + array[r];
            maxSum = Math.Max(maxSum, windowSum);
        }

        return windowSum;
    }
    
    public string CompressRanges(int[] array)
    {
        var left = 0;
        var right = 0;
        var result = new List<string>();

        while (left < array.Length)
        {
            while (right + 1 < array.Length && array[right + 1] == array[right] + 1)
            {
                right++;
            }

            if (left == right)
            {
                result.Add(array[left].ToString());
            }
            else
            {
                result.Add($"{array[left]}->{array[right]}");
            }

            left = ++right;
        }

        return string.Join(", ", result);
    }
    
    /*
    {1, 0, 1, 0, 1, 0, 1, 1}, 2

     1 0 1 0 1 0 1 1
        [           ]

    */
    public int MaxOneChanges(int[] array, int k)
    {
        var zeroCount = 0;
        var result = 0;

        for (int left = 0, right = -1; left < array.Length; left++)
        {
            for (; right + 1 < array.Length &&
                   (array[right + 1] == 1 || zeroCount < k); right++)
            {
                if (array[right + 1] == 0)
                {
                    zeroCount++;
                }
            }

            result = Math.Max(right - left + 1, result);

            if (array[left] == 0)
            {
                zeroCount--;
            }
        }

        return result;
    }
}