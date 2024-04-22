using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class MajorityElement169
    {
        public int majorityElement(int[] nums)
        {

            var dic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic.Add(num, 1);
                }
            }     

            return dic.OrderByDescending(p => p.Value).First().Key;
                
        }
    }
}
