using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class RemoveElement27
    {
        public int RemoveElement(int[] nums, int elem)
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != elem)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }
    }
}
