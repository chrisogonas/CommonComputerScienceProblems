using System;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
    /// <summary>
    /// C# program to merge two sorted linked lists in-place.
    /// </summary>
    class MergeOrderedLinkedLists
    {
        static Node mergeLists(Node head1, Node head2)
        {
            Node current1 = head1, next1 = head1.next;
            Node current2 = head2, next2 = head2.next;

            while (next1 != null && current2 != null)
            {
                if (current2.Data >= current1.Data &&
                    current2.Data <= next1.Data)
                {
                    next2 = current2.next;
                    current2.next = current1.next;
                    current1.next = current2;

                    current1 = current2;
                    current2 = next2;
                }
                else
                {
                    // where list 1 is longer than list 2
                    if (next1.next != null)
                    {
                        next1 = next1.next;
                        current1 = current1.next;
                    }
                    else
                    {
                        // list 1 is shorter
                        // route end of 1 to current head of 2
                        next1.next = current2;
                        return head1;
                    }
                }
            }
            return head1;

        }
    }

    class Node
    {
        public Node next = null;
        public int Data { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }
    }
}
