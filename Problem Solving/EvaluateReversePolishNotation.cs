namespace Problem_Solving;

public partial class Solution
{
    public int EvalRPN(string[] tokens)
    {
        int first = 0;
        int second = 0;
        Stack<string> ints = new Stack<string>();

        foreach (var token in tokens)
        {
            if ("+-*/".Contains(token))
            {
                second = Int32.Parse(ints.Pop());
                first = Int32.Parse(ints.Pop());

                if (token == "+")
                {
                    ints.Push(Convert.ToString(first + second));
                }
                else if (token == "-")
                {
                    ints.Push(Convert.ToString(first - second));
                }
                else if (token == "*")
                {
                    ints.Push(Convert.ToString(first * second));
                }
                else if (token == "/")
                {
                    ints.Push(Convert.ToString(first / second));
                }
            }
            else
                ints.Push(token);
        }
        return Convert.ToInt32(ints.Pop());
    }
}
