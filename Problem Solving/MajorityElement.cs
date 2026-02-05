namespace Problem_Solving;

public partial class Solution
{
    public int MajorityElement(int[] nums)
    {
        return nums.GroupBy(a=>a).OrderByDescending(a=>a.Count()).Select(a=>a.Key).First();
    }
}
