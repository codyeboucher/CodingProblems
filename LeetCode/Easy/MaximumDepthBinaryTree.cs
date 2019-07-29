using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Easy
{
    class MaximumDepthBinaryTree
    {
        //https://leetcode.com/problems/maximum-depth-of-binary-tree/
            //Given a binary tree, find its maximum depth.
            //The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.



        //traverse tree with BFS using queue to store nodes, 
        //store a null between "levels" of tree to know when to increment depth

        public static int MaximumDepth(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            var depth = 0;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(null);

            while(queue.Any())
            {
                var curr = queue.Dequeue();
                if(curr == null)
                {
                    if(queue.Any())
                    {
                        queue.Enqueue(null);
                    }                    
                    depth++;
                }
                else
                {
                    if(curr.left != null)
                    {
                        queue.Enqueue(curr.left);
                    }
                    if(curr.right != null)
                    {
                        queue.Enqueue(curr.right);
                    }
                }
            }
            return depth;
        }
    }
}
