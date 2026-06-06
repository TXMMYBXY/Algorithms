using Structures.Graph;

namespace Algorithms.SearchAlgorithm;

public class FindHelper
{
    public static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        for (int i = 0; i < Math.Log2(array.Length); i++)
        {
            var middle = (left + right) / 2;

            if (target == array[middle])
            {
                return middle;
            }
            else if (target < array[middle])
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return -1;
    }
    
    private static int BinarySearch(int[] arr, int left, int right, int target)
    {
        if (left > right)
        {
            return -1;
        }

        var mid = (right + left) / 2;
        var temp = arr[mid];

        if (temp == target)
            
        {
            return mid;
        }
        
        return temp > target 
            ? BinarySearch(arr, left, mid - 1, target) 
            : BinarySearch(arr, mid + 1, right, target);
    }
    
    private static bool BreadthSearch(Node root, string name)
    {
        var searchQue = new Queue<Node>();
        var searched = new HashSet<Node>();
        
        searchQue.Enqueue(root);

        while (searchQue.Count > 0)
        {
            var person = searchQue.Dequeue();

            if (!searched.Contains(person))
            {
                if (person.Name.Equals(name))
                    return true;
                
                foreach (var item in person.Neighbors)
                {
                    searchQue.Enqueue(item);
                }
                
                searched.Add(person);
            }
        }
        
        return false;
    }
}