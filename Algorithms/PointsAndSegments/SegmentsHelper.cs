namespace Algorithms.PointsAndSegments;

public class SegmentsHelper
{
    public List<int[]> Merge(int[][] segments)
    {
        Array.Sort(segments, (x, y) => x[0].CompareTo(y[0]));

        List<int[]> result = new();
        
        result.Add(segments[0]);

        for (int i = 0; i < segments.Length; i++)
        {
            var last = result[^1];
            var current = segments[i];

            if (_IsOverlap(last, current))
            {
                result.Insert(result.Count - 1, _MergeTwo(last, current));
            }
            else
            {
                result.Add(current);
            }
        }

        return result;
    }

    private bool _IsOverlap(int[] first, int[] second) 
        => Math.Max(first[0], second[0]) <= Math.Min(first[1], second[1]);
    
    private int[] _MergeTwo(int[] first, int[] second)
        => [Math.Min(first[0], second[0]), Math.Max(first[1], second[1])];
}