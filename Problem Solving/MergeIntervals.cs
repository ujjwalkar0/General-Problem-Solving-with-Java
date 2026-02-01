namespace Problem_Solving;

public partial class Solution
{
    public int[][] merge(int[][] intervals) {
        Array.Sort(intervals, (a,b)=> a[0].CompareTo(b[0]));
        HashSet<int[]> results = new HashSet<int[]>();

        if (intervals.Length==1)
            return intervals;
        
        for (int i=1; i<intervals.Length; i++)
        {
            if (intervals[i-1][1] >= intervals[i][0])
            {
                results.Add([intervals[i-1][0], intervals[i][1]]);                
            }
            else if (results.Last()[1] >= intervals[i-1][0])
            {
                results.Add(intervals[i-1]);
                results.Add(intervals[i]);                
            }
        }

        return results.ToArray();
    }
}