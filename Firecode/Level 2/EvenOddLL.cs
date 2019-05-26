using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTwo
{
    class EvenOddLL
    {
        /*Given a singly-linked list, check whether its length is even or odd in a single pass. 
         * An Empty list has 0 nodes which makes the number of nodes in it even.
        * Examples:
        * 1->2->3->4 == true 1->2->3->4->5 == false*/

        public static bool IsListEven(ListNode head)
        {
            if (head == null)
            {
                return true;
            }

            var curr = head;

            while (curr != null || curr.next != null)
            {
                curr = curr.next.next;
            }

            return curr == null;

        }
    }
}
