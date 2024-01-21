using LC.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub
{
    public class FlattenTree114
    {

        TreeNode curPointer;
        public void Flatten(TreeNode root)
        {
            var result = PreOrder(root);
            root = result;
        }

        private TreeNode PreOrder(TreeNode root)
        {
            TreeNode result = null;
            if (root == null)
                return root;
            var node = new TreeNode(root.val);
            Debug.WriteLine(root.val);
            if (curPointer == null)
            {
                curPointer = node;
                result = curPointer;
            }
            else
            {
                curPointer.right = node;
                curPointer = curPointer.right;
            }
            //            Console.WriteLine(root.val);
            PreOrder(root.left);
            PreOrder(root.right);
            return result;
        }
    }


}
