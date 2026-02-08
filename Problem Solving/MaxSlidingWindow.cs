namespace Problem_Solving;

public partial class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int max = 0;

        List<int> listOfMax = new List<int>();

        for (int i=0; i<k; i++)
        {
            if (nums[i]>max){
                max = nums[i];
            }
        }

        listOfMax.Add(max);

        for (int i=k; i< nums.Length; i++){
            if (nums[i]>max){
                listOfMax.Add(nums[i]);
                max = nums[i];
            }
            else if (nums[nums.Length-k]==max){
                // listOfMax.Add(secondMax);
            }
        }

        return listOfMax.ToArray<int>();
    }
}
