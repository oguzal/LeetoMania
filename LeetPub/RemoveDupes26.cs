using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{

    public  class RemoveDupes26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int uniquePointer = 0;
            for (int i = 1; i < nums.Length; i++)
            {                
                if (nums[uniquePointer] != nums[i])
                {
                    nums[++uniquePointer] = nums[i];
                }
            }
            return uniquePointer + 1;
        }
        public int RemoveDuplicates2(int[] nums)
        {
            int dupeCount = 0;
            for (int x = 0; x < nums.Length-1; x++)
            {
                if (nums[x] == nums[x + 1])
                {
                    // 1 1 2 2 3 3
                    //   ^ 
                    // nums[1]=nums[2]
                    // nums[2]=nums[3]
//                    { 1,1,1,2,2});--> 1 2 222
//                        

                dupeCount++;
                    for (int y = x; y < nums.Length - 1 ; y++)
                    {
                       // System.out.println(y);
                        nums[y] = nums[y + 1];
                    }
                }
            }
            return nums.Length- dupeCount;
        }
    }
}
