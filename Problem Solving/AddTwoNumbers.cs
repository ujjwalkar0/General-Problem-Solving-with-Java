using Models;

namespace Problem_Solving;

public partial class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode listNode = new ListNode();
        while(l1.next != null)
        {
            if (listNode.next == null)
            {
                listNode.val = l1.val+l2.val;
                listNode.next = new ListNode();
            }
            else {
                listNode.next = new ListNode();
                listNode.next.val = l1.val + l2.val;

            }
        }

        return listNode;
    }
}
