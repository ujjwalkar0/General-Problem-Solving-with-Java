namespace Problem_Solving;

public partial class Solution
{
    // Solution will o(n2) complexity
    private void Shift(int[] arr)
    {
        int temp = arr[arr.Length - 1];
        for (int i = arr.Length - 1; i > 0; i--)
        {
            arr[i] = arr[i - 1];
        }
        arr[0] = temp;
    }



    private void ReverseArray(int[] arr, int start, int end)
    {
        int temp;

        for (int i = start; i < start+(end-start)/2; i++)
        {
            temp = arr[i];
            arr[i] = arr[end - i];
            arr[end - i] = temp;
        }
    }

    public void Rotate(int[] nums, int k)
    {
        ReverseArray(nums, 0, nums.Length-1);
        ReverseArray(nums, 0, k-1);
        ReverseArray(nums, k, nums.Length-1);
    }
}
