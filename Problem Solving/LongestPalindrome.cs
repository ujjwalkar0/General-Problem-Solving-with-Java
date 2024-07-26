// https://leetcode.com/problems/longest-palindromic-substring/description/

namespace Problem_Solving
{
    public partial class Solution
    {

        public bool isPalindrom(string s)
        {

            if (s.Length == 1)
            {
                return true;
            }

            for (int i = 0; i <= s.Length/2; i++)
            {
                if (s[i] != s[s.Length - i -1])
                    return false;
            }
            return true;
        }

        public bool isLongestPalindrom(string s, int currentLongestlen)
        {
            if (isPalindrom(s))
            {
                if (s.Length > currentLongestlen)
                {
                    return true;
                }
            }
            return false;
        }

        public string LongestPalindrome(string s)
        {
            string subStr = "";
            string longestSubstring = "";

            if (s.Length == 1)
            {
                return s;
            }

            if ((s.Length == 2) && (s[0] == s[1]))
            {
                return s;
            }


            for (int start = 0; start < s.Length; start++)
            {
                for (int size = 1; size <= s.Length-start; size++)
                {
                    subStr = s.Substring(start, size);
                    if (isLongestPalindrom(subStr, longestSubstring.Length))
                    {
                        longestSubstring = subStr;
                    }
                }
            }
            return longestSubstring;
        }
    }
}
