using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class InsertNodeEndLL
    {
        /*Write a method to insert a node at the end of a singly-linked list. Return the head of the modified list.
        * Examples:
        * LinkedList: 1->2 , Head = 1
        * InsertAtTail(Head,1) ==> 1->2->1
        * InsertAtTail(Head,2) ==> 1->2->2
        * InsertAtTail(Head,3) ==> 1->2->3*/

        public ListNode InsertAtTail(ListNode head, int data)
        {
            var newNode = new ListNode(data);

            if(head == null)
            {
                head = newNode;
            }
            else
            {
                var curr = head;

                while(curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = newNode;
            }
            return head;
        }
    }
}
