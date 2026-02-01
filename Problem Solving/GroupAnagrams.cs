namespace Problem_Solving;

public partial class Solution
{
    // sort a string
    private string SortString(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        return new String(chars);
    }
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        string[] sortedStrings = strs.Select(a=>SortString(a)).ToArray();

        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        for (int i = 0; i < sortedStrings.Length; i++)
        {
            if (anagrams.ContainsKey(sortedStrings[i]))
            {
                anagrams[sortedStrings[i]].Add(strs[i]);
            }
            else
            {
                anagrams.Add(sortedStrings[i], [strs[i]]);
            }
        }

        return anagrams.Values.Select(v => (IList<string>)v).ToList();

    }
}