using System.Collections.Generic;

namespace Problem_Solving;

public partial class Solution
{
    private int fun(int div, HashSet<int> ints)
    {
        int mod = 0;
        int res = 0;

        if (ints.Contains(div))
            return 0;

        ints.Add(div);

        while (div != 0)
        {
            mod = div % 10;
            res = res + mod * mod;
            div = div / 10;
        }

        if (res == 1)
            return 1;

        return fun(res, ints);
    }
    public bool IsHappy(int n)
    {
        int div = n;
        HashSet<int> ints = new HashSet<int>();

        return fun(div, ints) == 1;
    }
}
