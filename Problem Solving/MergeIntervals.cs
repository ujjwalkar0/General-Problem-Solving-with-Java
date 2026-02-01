namespace Problem_Solving;

public partial class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> results = new List<int[]>();

        results.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++)
        {
            var lastResult = results[results.Count-1];

            if (lastResult[1] >= intervals[i][0])
            {
                lastResult[1] = Math.Max(intervals[i][1], lastResult[1]);
            }
            else
            {
                results.Add(intervals[i]);
            }
        }

        return results.ToArray();
    }
}