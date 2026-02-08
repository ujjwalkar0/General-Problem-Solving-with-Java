using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Models;

namespace Problem_Solving;

public partial class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;
        ListNode next;

        while (curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;

        // ToDo: Try it in recursive way
    }
}
