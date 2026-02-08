namespace Problem_Solving;

public partial class Solution
{
    private void LetsPlay(int[] arr, int[] blocked, int player, out int ans)
    {
        if (blocked[blocked.Length - 2] == 1)
        {
            if (blocked[0]==0) ans = arr[0];
            else ans = arr[arr.Length - 1];
        }
        else
        {
            int m = player == 0 ? arr.Where((val, index) => blocked[index] != 1).Max() : arr.Where((val, index) => blocked[index] != 1).Min();
            int l = Array.FindIndex(blocked, val => val != 1);
            int r = 0;
            ans = 0;

            for (int i = l; i < arr.Length; i++)
            {
                r = i;
                if (arr[i] == m)
                    if (i==0) continue;
                    else break;
                if (arr[r] - arr[l] + 1 < arr.Length)
                    blocked[i] = 1;
            }

            player = player == 0 ? 1 : 0;
            LetsPlay(arr, blocked, player, out ans);
        }
    }
    public int FinalElement(int[] nums)
    {
        if (nums.Distinct().Count() == 1)
            return nums[0];
        if (nums.Length==2)
            return Math.Max(nums[0], nums[1]);
        int[] blocked = new int[nums.Length];
        int ans;

        LetsPlay(nums, blocked, 0, out ans);
        return ans;
    }
}
