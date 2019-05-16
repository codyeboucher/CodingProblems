using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class DeleteHeadNodeLL
    {
        /*Given a singly-linked list, write a method to delete the first node of the list and return the new head.
        * Example:
        * LinkedList: 1->2->3 , Head = 1
        * deleteAtHead(Head) ==> 2->3*/

        public ListNode DeleteHead(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return null;
            }
            var temp = head.next;
            head.next = null;
            head = temp;
            return head;
        }
    }
}
