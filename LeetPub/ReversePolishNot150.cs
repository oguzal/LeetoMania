using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class ReversePolishNot150
    {
        public int EvalRPN2(string[] tokens)
        {
            if (tokens.Length == 1)
                return Convert.ToInt32( tokens[0]);
            var cur = tokens.Length - 1;
            var op = tokens[cur];
            cur--;
            var val1 = Convert.ToInt32(tokens[cur]);

            string[] subset = new string[tokens.Length - 2];
            Array.Copy(tokens, 0, subset, 0, tokens.Length - 2);
            var val2 = EvalRPN(subset);

            if (op == "+")
                return val1 + val2;
            else if (op == "-")
                return val2 + val1;
            else if (op == "*")
                return val2 * val1;
            else if (op == "/")
                return val2 / val1;
            else return Convert.ToInt32(tokens[0]);

        }

        public int EvalRPN(string[] tokens)
        {
            var st = new Stack<int>();
            foreach (var t in tokens)
            {
                if (t == "/" || t == "*" || t == "+" || t == "-")
                {
                    var val1 = Convert.ToInt32( st.Pop());
                    var val2 =Convert.ToInt32( st.Pop());
                    if (t == "/")
                        st.Push(val2 / val1);
                    else if (t == "*")
                        st.Push(val2 * val1);
                    else if (t == "+")
                        st.Push(val2 + val1);
                    else if (t == "-")
                        st.Push(val2 - val1);
                }
                else st.Push(Convert.ToInt32(t));
            }
            var res= st.Pop();
            return Convert.ToInt32(res);
        }
    }
}
