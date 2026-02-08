namespace Problem_Solving;

public partial class Solution
{
    private bool IsMonoBit(string bin){
        int a = bin[0];
        for (int i=1; i<bin.Length; i++){
            if (a != bin[i]) return false;
        }
        return true;
    }
    public int CountMonobit(int n)
    {
        int count = 0;
        for (int i=0; i<n+1; i++){
            if (IsMonoBit(Convert.ToString(i, 2))){
                count++;
            }
        }
        return count;
    }
}
