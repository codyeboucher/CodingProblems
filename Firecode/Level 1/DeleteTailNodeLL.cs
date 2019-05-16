using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class DeleteTailNodeLL
    {
        /*Given a singly-linked list, write a method to delete its last node and return the head.
        * Example:
        * 1->2->3->4 ==> 1->2->3*/

        public ListNode DeleteTail(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return null;
            }

            var curr = head;
            
            while(curr.next.next != null)
            {
                curr = curr.next;
            }

            curr.next = null;
            return head;
        }
    }
}
