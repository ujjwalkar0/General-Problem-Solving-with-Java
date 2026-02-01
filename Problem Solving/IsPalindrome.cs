namespace Problem_Solving;

public partial class Solution
{
    public bool IsPalindrome(string s)
    {
        string str = String.Join("",s.Where(a => Char.IsLetterOrDigit(a))).ToLower();

        for(int i=0; i< str.Length/2; i++)
        {
            if (str[i]!=str[str.Length-1-i]) return false;
        }

        return true;
    }
}
