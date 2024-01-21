using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public  class ReverseWords151
    {
        public string ReverseWords(string s)
        {
            //Input: s = "the sky is blue"
            //        Output: "blue is sky the"

            // add to curword till space
            // add the curword to the end of the new string
            var words = s.Trim().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var revWords = words.Reverse();
            var newStr = new StringBuilder();
            foreach (string w in revWords)
            {
                newStr.Append(w.Trim());
                newStr.Append(" ");
            }
             return newStr.ToString().Substring(0, newStr.Length-1);
        }
    }
}
