using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public partial class Solution
    {
        public bool CanBeIncreasing(int[] nums)
        
        {
            Stack<int> sc = new Stack<int>();
            int temp = nums[0];
            int count = -1;
            int highest = nums[0];
            sc.Push(temp);

            for (int i = 1; i<nums.Length; i++)
            {
                while((sc.Count !=0) && (sc.Peek() >= nums[i]))
                {

                    if (count == -1)
                    {
                        highest = sc.Pop();
                        count++;
                    }   
                    else
                    {
                        sc.Pop();

                        if (highest > nums[i+1])
                        {
                            return true;
                        }
                        return false;
                    }
                }    
                sc.Push((int)nums[i]);
            }

            return true;
        }

    }
}
