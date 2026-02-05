namespace Problem_Solving;

public partial class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> keyValuePairs_a = new Dictionary<char, char>();
        Dictionary<char, char> keyValuePairs_b = new Dictionary<char, char>();
        char[] s_chars = s.ToCharArray();
        char[] t_chars = t.ToCharArray();

        for (int i = 0; i < s.Length; i++)
        {
            if (keyValuePairs_a.ContainsKey(s_chars[i]))
            {
                if (keyValuePairs_a[s_chars[i]] != t_chars[i])
                    return false;
            }
            else if (keyValuePairs_b.ContainsKey(t_chars[i]))
            {
                if (keyValuePairs_b[t_chars[i]] != s_chars[i])
                    return false;

            }
            else
            {
                keyValuePairs_a.Add(s_chars[i], t_chars[i]);
                keyValuePairs_b.Add(t_chars[i], s_chars[i]);
            }
        }

        return true;
    }

    // More Optimized version Generated with AI.
    //
    // public bool IsIsomorphic(string s, string t)
    // {
    //     if (s.Length != t.Length)
    //         return false;
    //
    //     int[] mapST = new int[256];
    //     int[] mapTS = new int[256];
    //     for (int i = 0; i < s.Length; i++)
    //     {
    //         if (mapST[s[i]] != mapTS[t[i]])
    //             return false;
    //
    //         mapST[s[i]] = i + 1;
    //         mapTS[t[i]] = i + 1;
    //     }

    //     return true;
    // }

}
