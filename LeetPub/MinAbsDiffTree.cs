using LC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class MinAbsDiffTree
    {
        public int GetMinimumDifference(TreeNode root)
        {

            int min = Int32.MaxValue;
            var list = new List<int>();
            list = GetList(root, new List<int>());
            for (int x = 1; x < list.Count; x++)
            {

                min = Math.Min(Math.Abs(list[x] - list[x - 1]), min);
            }
            return min;
        }

        public List<int> GetList(TreeNode root, List<int> list)
        {
            if (root == null) return list;
            GetList(root.left,list);
            list.Add(root.val);
            GetList(root.right,list);
            return list;
        }
    }
}
