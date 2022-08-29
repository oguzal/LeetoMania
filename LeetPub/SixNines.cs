using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
namespace LeetPub
{
    public class SixNines
    {
        //        // write a program that takes an 
        //        [bash]$ ./frequencies example.txt 10 
        //5 : the
        //3 : and
        //2 : from
        //2 : his
        //2 : he
        //2 : it
        //2 : i
        //1 : man
        //1 : sprang
        //1 : chair

        public Dictionary<string, int> WordCounter(string input)
        {
            var dic = new Dictionary<string, int>();
            var wordStartIndex = 0;
            var pointerIndex = 0;
            var listPunctuatin = new List<char>() { ',', ' ', '.', ':' };

            // the  and  from
            //      ^
            // word=the

            var word = new StringBuilder();

            while (pointerIndex < input.Length)
            {

                if (!listPunctuatin.Contains(input[pointerIndex]))
                {
                    word.Append(input[pointerIndex]);
                }
                else
                {
                    var wordToStr = word.ToString();
                    if (dic.ContainsKey(wordToStr))
                        dic[wordToStr]++;
                    else dic.Add(wordToStr, 1);
                    word = new StringBuilder();
                }
                //                if string[pointerIndex] ==","
                pointerIndex++;
            }
            //            a words=input.Split 
            //            ^
            var result = dic.OrderByDescending(p => p.Value).ToDictionary(p=>p.Key,p=>p.Value);
            return result;
        }

    }
}
