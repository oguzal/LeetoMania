using LC.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class UniqueBinaryTreesII_96
    {
        List<TreeNode> trees = new List<TreeNode>();

        public IList<TreeNode> GenerateTrees(int n)
        {
            for (int x = 1; x <= n; x++)
            {
                var tree = new TreeNode(x);
                trees.Add(tree);
                ExtendRoot(tree, n, new List<int> { x });
            }
            return trees;
        }

        public TreeNode ExtendRoot(TreeNode root, int n, List<int> nodesVisited)
        {

            if (nodesVisited.Count == n)
            {
                //                trees.Add(root);
                return root;
            }
            for (int x = 1; x <= n; x++)
            {
//                if (!nodesVisited.Contains(x))
                {
                    nodesVisited.Add(x);
                    root.left = new TreeNode(x);
                    ExtendRoot(root.left, n, nodesVisited);
                    var nextNode = NextNode(x, n);
                    root.right = new TreeNode(nextNode);
                    ExtendRoot(root.right, n, nodesVisited);
                }
            }
            return root;
        }

        public int NextNode(int cur, int n)
        {
            return n == cur ? 1 : n + 1;         
        }

    }
}
