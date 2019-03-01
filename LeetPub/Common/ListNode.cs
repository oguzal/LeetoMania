using System;
using System.Collections.Generic;
using System.Text;

namespace LC.Common
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
        public string Reverse(string inp)
        {

            var str = new StringBuilder();
            for (int x = inp.Length - 1; x >= 0; x--)
            {
                str.Append(inp[x]);
            }
            return str.ToString();
        }

    }


}
