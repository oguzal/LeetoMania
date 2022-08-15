using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class BinarySearch704
    {
        public int Search(int[] nums, int target)
        {

            var l = 0;
            var r = nums.Length - 1;
            while (l < r)
            {
                int mid = l + (r - l) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                {
                    r = mid - 1;
                }
                else l = mid + 1;

            }
            return -1;
        }
    }
}
