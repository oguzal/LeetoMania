using LC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class MergeBinaryTrees617
    {
     //   TreeNode result = new TreeNode(0);

        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {


            return Merge(root1, root2);
        }
        public TreeNode Merge(TreeNode root1, TreeNode root2)
        {

            if (root1 == null && root2 == null) return root2;
            if (root1 == null)
            {
                //curNode.val = root2.val;
                //curNode.left = new TreeNode(0);
                Merge(null, root2.left);
            }
            else if (root2 == null)
            {
                Merge(root1.right, null);
            }
            else
            {
                root2.val = +root1.val; 

                //curNode.right = new TreeNode(0);
                Merge(root1.right, root2.right);

               // curNode.left = new TreeNode(0);
                Merge(root1.left, root2.left);
                
            }

            return root2;
        }
    }
}
