using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetPub
{
    public class NextRightPointerTree116
    {
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }


        public class Q
        {
            public int _level { get; set; }
            public Node _node { get; set; }
            internal Q(int level, Node node)
            {

                _level = level;
                _node = node;
            }
        }
        public Node Connect(Node root)
        {
            //            var cur = new Q(0, root);
            Queue<Node> q = new Queue<Node>();
            var level = 0;
            q.Enqueue(root);
            while (q.Any())
            {
                for (int x = 0; x < Math.Pow(2, level); x++)
                {
                    Node leftNode = null;
                    //Node rightNode;
                    var cur = q.Dequeue();
                    if (x == Math.Pow(2, level - 1))
                        leftNode = cur;
                    if (x == Math.Pow(2, level) + 1 )
                    {
                        leftNode.next = cur;
                    }

                    if (cur.left != null)
                    {
                        q.Enqueue(cur.left);
                    }
                    if (cur.right != null)
                    {
                        q.Enqueue(cur.right);
                    }

                }
                level++;


            }
            return root;
        }
    }
}
