using System.Text;

namespace Algorithms.HashTables;

public class HashTableHelper
{
    public bool CanBePalindrome(string target)
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

        int oddCount = 0;

        foreach (var value in dict.Values)
        {
            if (value % 2 == 0)
            {
                oddCount++;
            }
        }

        return oddCount <= 1;
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