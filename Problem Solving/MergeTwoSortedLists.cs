// Not Completed
using Models;
namespace Problem_Solving;

public partial class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        while (true)
        {
            // check if both the lists are not null
            if (list1 != null && list2 != null){
                if (list1.val <= list2.val){
                    ListNode temp1 = list1.next;
                    ListNode temp2 = list1.next;
                    
                    list1.next = list2;
                    list2.next = temp1;

                    
                }
            }
        }

        return list1;
        // ListNode result = new ListNode();

        // while (true)
        // {
        //     if (list1 == null && list2 != null)
        //     {
        //         result.val = list2.val;
        //         result.next = list2.next;
        //         break;
        //     }
        //     else if (list2 == null && list1 != null)
        //     {
        //         result.val = list1.val;
        //         result.next = list1.next;
        //         break;
        //     }

        //     else if (list1 == null || list2 == null)
        //     {
        //         break;
        //     }
        //     else
        //     {
        //         result.val = Math.Max(list1.val, list2.val);

        //         // if (list1.val>lis)

        //         result.next = list1.val > list2.val ? list1.next : list2.next;
        //         list1 = list1.next;
        //         list2 = list2.next;
        //     }
        // }
        // return result;
    }
}