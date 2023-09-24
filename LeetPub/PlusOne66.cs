using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class PlusOne66
    {
        public int[] PlusOne(int[] digits)
        {
            var len = digits.Length;
            bool carry = false;
            for (int x = len-1; x >= 0; x--)
            {
                // 1 2 9
                //     0
                // if carry & 9 -> x=0;
                // if carry -> x++ , carry=false
                // if no carry x++ break; 
                // if at the end carry -> add 1
                if (!carry)
                {
                    if (digits[x] < 9)
                    {
                        digits[x]++;
                        break;
                    }
                    else
                    {
                        digits[x] = 0; carry = true;
                    }
                }
                else
                {
                    carry = false;
                    if (digits[x] == 9)
                    { carry = true; digits[x] = 0; }
                    else
                    {
                        digits[x]++;break;
                    }
                }

            }
            if (carry)
            {
                var list = digits.ToList();
                list.Insert(0, 1);
                digits = list.ToArray();
            }
            return digits;
        }
    }
}
