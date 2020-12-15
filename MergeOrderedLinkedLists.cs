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
            Node newHead = null, newTail = null;

            if (head1 == null && head2 != null) { return head2; }
            if (head2 == null && head1 != null) { return head1; }
            if (head1 == null && head2 == null) { return null; }

            if (head1.Data <= head2.Data)
            {
                newHead = head1;
                newTail = newHead;
            }
            if (head2.Data < head1.Data)
            {
                newHead = head2;
                newTail = newHead;
            }

            while (current1 != null && current2 != null)
            {
                if (current1.Data <= current2.Data)
                { // node in 1 is less or equal
                  // Console.Write($"{current1.data} ");
                    next1 = current1.next;
                    newTail.next = current1;
                    current1.next = null;
                    newTail = current1;
                    current1 = next1;
                }
                else
                { // node in 2 is less
                  // Console.Write($"{current2.data} ");
                    next2 = current2.next;
                    newTail.next = current2;
                    current2.next = null;
                    newTail = current2;
                    current2 = next2;
                }
            }

            // where list 1 is longer than list 2
            if (current1 != null)
            {
                newTail.next = current1;
            }

            // list 2 is longer
            if (current2 != null)
            {
                newTail.next = current2;
            }

            return newHead;

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
