using System.Text;

namespace Algorithms.Point;

public class PointerHelper
{
    public int[] TwoSide(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var currentSum = nums[left] + nums[right];

            if (currentSum == target)
            {
                return [left, right];
            }
            
            if (currentSum < target)
            {
                left++;
            }
            else
            {
                right--;
            }

        }

        return [-1, -1];
    }

    public List<int> EverybodyIndex(int[] firstArray, int[] secondArray)
    {
        var firstIndex = 0;
        var secondIndex = 0;
        var result = new List<int>();

        while (firstIndex < firstArray.Length && secondIndex < secondArray.Length)
        {
            if (firstArray[firstIndex] == secondArray[secondIndex])
            {
                result.Add(firstArray[firstIndex]);
                firstIndex++;
                secondIndex++;
            }
            else if (firstArray[firstIndex] < secondArray[secondIndex])
            {
                firstIndex++;
            }
            else
            {
                secondIndex++;
            }
        }

        return result;
    }

    public int[] FastSlow(int[] array)
    {
        var slow = 0;
        var fast = 0;

        while (fast < array.Length)
        {
            if (array[fast] != 0)
            {
                (array[slow], array[fast]) = (array[fast], array[slow]);

                slow++;
            }

            fast++;
        }

        return array;
    }
}