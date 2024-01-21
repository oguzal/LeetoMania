using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class LongestCommonPrefix14
    {
        public string LongestCommonPrefix(string[] strs)
        {

            var commonPrefix = new StringBuilder();
            var shortestLength = strs.Min(p => p.Length);
            // for each index
            for (int idx = 0; idx < shortestLength; idx++)
            { 
                // for each string, compare the current letter 
           
                // abc ab a
               //  ^   ^  ^
                bool flag = true;
                for (int x = 1; x < strs.Length ; x++)
                {
                    if (strs[x][idx] != strs[x - 1][idx]) { flag = false; break; }
                }
                if (flag) commonPrefix.Append(strs[0][idx]);
                else break;
            }
            return commonPrefix.ToString();
        }
    }
}
