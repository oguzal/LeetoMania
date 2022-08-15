using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class Fib509
    {
        public int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int[] dp = new int[n+1];
            dp[0] = 0;
            dp[1] = 1;

            for (int x = 2; x <= n; x++)
            {
                dp[x] = dp[x - 1] + dp[x - 2];
            }
            return dp[n];
        }
    }
}
