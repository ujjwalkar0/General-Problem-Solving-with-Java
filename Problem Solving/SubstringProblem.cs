using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public partial class Solution
    {
        public int isSameString(string haystack, string needle, int j)
        {
            if (haystack.Length - j < needle.Length) return -1;

            for (int i = 0; i < needle.Length; i++)
            {
                if (haystack[i + j] != needle[i])
                {
                    return -1;
                }
            }
            return j;
        }
        public int StrStr(string haystack, string needle)
        {
            int index = -1;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    index = isSameString(haystack, needle, i);

                    if (index != -1)
                        return index;
                }
            }

            return index;
        }
    }
}
