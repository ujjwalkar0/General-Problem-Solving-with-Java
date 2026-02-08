using Models;

namespace Problem_Solving;

public partial class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        Stack<int> ints = new Stack<int>();
        ListNode temp = head;

        while (temp != null)
        {
            ints.Push(temp.val);
            
            temp=temp.next;
        }

        while (head.next != null)
        {
            if (head.val != ints.Pop())
            {
                return false;
            }
            
            head=head.next;
        }
        
        return true;
        // Todo: Lets try with single loop
    }
}
