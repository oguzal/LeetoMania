using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class Divide2Integers29

    {  
        //create a function to divide two integers without using multiplication, division and mod operator.
        public int FindDivision(int dividend, int divisor)
        {          
            int count = 0;
            bool negFlag = false;
            if (dividend < 0 && divisor < 0)
            {
                dividend = -1 * dividend;   
                divisor = -1 * divisor;
            }
              
            if (dividend < 0)
            {
                dividend = -1 * dividend; negFlag = true;
            }
            if (divisor < 0)
            { divisor = -1 * divisor; negFlag = true; }

            while (dividend >= divisor)
            {
                dividend = dividend - divisor;
                count++;
            }
            if (negFlag)
                return -count;
            else return count;
        }
    }
}

