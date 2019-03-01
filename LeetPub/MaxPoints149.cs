using LC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LC
{
    public class MaxPoints149
    {
        public int MaxPoints(Point[] points)
        {
            if (points.Length == 0) return 0;
            if (points.Length == 1) return 1;

            var dic = new Dictionary<string, HashSet<int>>();
            for (int x = 0; x < points.Length; x++)
            {
                for (int y =0; y < points.Length; y++)
                {
                    var key = GetKey(points[x], points[y]);

                    if (key == "0") continue;
                    if (dic.ContainsKey(key))
                    {
                        dic[key].Add(x);
                        dic[key].Add(y);
                    }
                    else
                    {
                        var pointsList = new HashSet<int>();
                        pointsList.Add(x);
                        pointsList.Add(y);
                        dic.Add(key, pointsList);
                    }
                }
            }
            if (dic.Count() == 0) return 1;
            int maxP = 0;
//            foreach (KeyValuePair<string, List<Point>> ind in dic)
      //      {
  //              if (ind.Value.Count() > maxP)
    //                maxP = ind.Value.Count();
        //    }
            return dic.Max(p => p.Value.Distinct().Count());
        }

        public string GetKey(Point a, Point b)
        {
            if (a.y - b.y == 0) return "hline:" + a.x;
            if (a.x - b.x == 0) return "vline:" + a.x;
            decimal slope = (decimal)(a.x - b.x) /(a.y - b.y);
            int t;
            decimal interceptY = a.y - slope * a.x;

            return interceptY+":"+ slope.ToString();
        }
    }
}
