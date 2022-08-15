using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class SortedSquare977
    {
        public int[] SortedSquares(int[] nums)
        {
            var minusNrs = new List<int>();
            int idxNums = 0;
            for (int x = 0; x < nums.Length; x++)
            {
                if (nums[x] < 0)
                    minusNrs.Add(-nums[x]);
                else
                {
                    idxNums = x;
                    break;
                }
            }

            minusNrs.Reverse();

            if (minusNrs.Count == nums.Length) idxNums = nums.Length;
            // merge to a new array
            var idxMinus = 0;
            var newArr = new List<int>();

            while (idxMinus < minusNrs.Count && idxNums < nums.Length)
            {

                if (minusNrs[idxMinus] < nums[idxNums])
                {
                    newArr.Add(minusNrs[idxMinus] * minusNrs[idxMinus]);
                    idxMinus++;

                }
                else
                {
                    newArr.Add(nums[idxNums] * nums[idxNums]);
                    idxNums++;

                }
            }
            if (idxMinus == minusNrs.Count)
            {
                // add all the nums arr to the new arr
                for (int x = idxNums; x < nums.Length; x++)
                    newArr.Add(nums[x] * nums[x]);
            }
            if (idxNums == nums.Length)
            {
                // add all the zero Nrs to the new arr
                for (int x = idxMinus; x < minusNrs.Count; x++)
                    newArr.Add(minusNrs[x] * minusNrs[x]);
            }
            return newArr.ToArray();
        }
    }
}
