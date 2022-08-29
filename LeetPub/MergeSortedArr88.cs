using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class MergeSortedArr88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            var p0 = m;
            var p1 = 0; var p2 = 0;
            for (int x=0;x< m && p2<n;x++ )
            {

                if (nums1[p1] <= nums2[p2])
                    p1++;
                else
                {
                    nums1[p0] = nums1[p1];
                    nums1[p1] = nums2[p2];
                    p0++;
                    p2++;
                }
            }

            for (int x = p2; x < nums2.Length; x++) {
                nums1[p0] = nums2[p2];
                p0++;
                p2++;
            }

        }
    }
}
