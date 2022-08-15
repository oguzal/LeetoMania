using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class AncestorNodeGraph2192
    {


        public IList<IList<int>> GetAncestors(int n, int[][] edges)
        {
            var dic = new Dictionary<int, List<int>>();
            foreach (var r in edges)
            {
                if (dic.ContainsKey(r[1]))
                {
                    dic[r[1]].Add(r[0]);
                }
                else dic.Add(r[1], new List<int>() { r[0]});
            }


            return null;

        }

    }
}
