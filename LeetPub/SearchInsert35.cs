using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class SearchInsert35
    {
        public int SearchInsert(int[] nums, int target)
        {
            var r = nums.Length-1;
  
            var l = 0;
            if (nums[0] > target) return 0;
            if (nums[r - 1] < target) return r;
    
            while (l<r)
            {

                int mid = l + (r - l) / 2;
                if (nums[mid] == target) return mid;

                else if (nums[mid] > target)
                {
                    r = mid-1;    
                }
                else
                {
                    l = mid + 1;
                }
            }
            return l;
        }
    }
}
