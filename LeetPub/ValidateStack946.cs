using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetPub
{
    public class ValidateStack946
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            int len = pushed.Length;
            int po = 0;
            int pu = 0;
            var stack = new Stack<int>() { };
            int? cur = null;
            while (pu < len)
            {

                if (stack.Any())
                { cur = stack.Peek(); }
                if (pushed[pu] == popped[po])
                {
                    pu++;
                    po++;
                }
                else if (cur.HasValue
                    && cur.Value == popped[po])
                {
                    cur = stack.Pop();
                    po++;

                    if (cur != pushed[pu]) return false;
                }
                else
                {
                    stack.Push(pushed[pu]);
                    pu++;
                }
            }
            return true;
        }
    }
}
