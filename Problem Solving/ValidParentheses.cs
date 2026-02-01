using System.Collections.Generic;

namespace Problem_Solving;

public partial class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char i in s){
            if (stack.Count == 0) {
                stack.Push(i);
                continue;
            }
            if (i == ')' && stack.Peek() == '(')
                stack.Pop();
            else if (i == '}' && stack.Peek() == '{')
                stack.Pop();
            else if (i == ']' && stack.Peek() == '[')
                stack.Pop();
            else
                stack.Push(i);
        }

        return stack.Count == 0;
    }
}