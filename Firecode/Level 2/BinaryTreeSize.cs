using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTwo
{
    class BinaryTreeSize
    {
        /*Given a binary tree, write a method to return its size. 
         * The size of a tree is the number of nodes it contains.*/
        
        //recursively find tree size
        public static int TreeSizeRec(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }
            else
            {
                return 1 + TreeSize(root.left) + TreeSize(root.right);
            }
        }

        //iteratively find tree size
        public static int TreeSizeItr(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            var nodeCount = 0;
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while(stack.Any())
            {
                var curr = stack.Pop();
                nodeCount++;

                if(curr.right != null)
                {
                    stack.Push(curr.right);
                }
                if(curr.left != null)
                {
                    stack.Push(curr.left);
                }
            }

            return nodeCount;

        }
    }
}
