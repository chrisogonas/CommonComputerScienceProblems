using System;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
    class DoublyLinkedList
    {

        /// <summary>
        /// Insert a node into a sorted double-linked list
        /// </summary>
        /// <param name="head"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        static DblNode SortedInsert(DblNode head, int data)
        {
            DblNode node = head;
            DblNode newNode = new DblNode(data);
            DblNode tempNode = head;

            if (node == null) { return new DblNode(data); } // empty

            // 1 node
            if (node.Next == null)
            {

                if (head.Data < data)
                {
                    head.Next = newNode;
                    newNode.Previous = head;
                    return head;
                }
                else
                {
                    newNode.Next = head;
                    head.Previous = newNode;
                    return newNode;
                }
            }

            // new data smaller or equal to head
            if (head.Data >= data)
            {
                newNode.Next = head;
                head.Previous = newNode;
                return newNode;
            }

            while (head != null)
            {
                if (head.Next == null)
                { // at the end of list
                    if (head.Data < data)
                    {
                        head.Next = newNode;
                        // head.prev.next = newNode;
                        newNode.Previous = head;
                    }
                    else
                    {
                        newNode.Previous = head.Previous;
                        newNode.Next = head;
                        head.Previous.Next = newNode;
                        head.Previous = newNode;
                    }
                    break;
                }
                else
                { // somewhere midway in the list
                    if (head.Next.Next != null)
                    {
                        if (data >= head.Data && data <= head.Next.Data)
                        {
                            newNode.Next = head.Next;
                            head.Next = newNode;
                            newNode.Previous = head;
                            break;
                        }
                    }
                }

                head = head.Next;
            }

            return tempNode;
        }

        /// <summary>
        /// Reverse the order of the nodes of a doubly linked list in place, given the pointer to the head.
        /// </summary>
        /// <param name="head">pointer to the list head</param>
        /// <returns>new list head</returns>
        public static DblNode reverse(DblNode head)
        {
            DblNode previous = null;
            DblNode current = head;
            DblNode next = head.Next;

            if (current == null || current.Next == null) { return current; } // empty or 1 node

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                current.Previous = current.Next;
                previous = current;
                current = next;
            }

            return previous;

        }
    }
}

class DblNode
{
    public DblNode Next = null;
    public DblNode Previous = null;
    public int Data { get; set; }

    public DblNode(int data)
    {
        this.Data = data;
    }
}