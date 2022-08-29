using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class ClimbingStairs70
    {
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;
            for (int x = 3; x <= n; x++)
            {
                dp[x] = dp[x - 1] + dp[x - 2];

            }
            return dp[n];
        }
    }
}
