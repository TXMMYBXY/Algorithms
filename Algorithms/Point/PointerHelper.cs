using System.Collections;
using System.Reflection;
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
    
    public string FrequencySort(string target)
    {
        var dict = new Dictionary<char, int>();

        foreach (var c in target)
        {
            if (!dict.ContainsKey(c))
            {
                dict.Add(c, 1);
            }
            else
            {
                dict[c]++;
            }
        }

        var inverseDict = new Dictionary<int, char>();

        foreach (var c in dict)
        {
            inverseDict.Add(c.Value, c.Key);
        }

        var freqList = new char[target.Length];

        foreach (var a in inverseDict.Keys)
        {
            freqList[a] = inverseDict[a];
        }

        var result = new StringBuilder();

        for (int freq = freqList.Length - 1; freq >= 0; freq--)
        {
            if (!char.IsWhiteSpace(freqList[freq]))
            {
                result.Append(new string(freqList[freq], freq));
            }
        }

        return result.ToString();
    }
}