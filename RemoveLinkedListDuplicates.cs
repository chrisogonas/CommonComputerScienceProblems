using System;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
    /// <summary>
    /// Remove duplicate nodes
    /// </summary>
    class RemoveLinkedListDuplicates
    {
        static Node removeDuplicates(Node head)
        {
            Node current = head;
            Node newHead = null;
            bool headSet = false;
            while (current != null)
            {
                if (!headSet)
                {
                    newHead = current;
                    headSet = true;
                }
                if (current.Next != null)
                {
                    if (current.Next.Data == current.Data)
                    {
                        if (current.Next.Next != null)
                        {
                            current.Next = current.Next.Next; // skip similar node
                        }
                        else
                        {
                            current.Next = current.Next.Next; // skip last similar node
                            break; // end of list
                        }
                    }
                    else
                    { // neighbors are unique
                        current = current.Next;
                    }
                }
                else
                {
                    current = current.Next; // advance to null if at the end
                }
            }

            return newHead;
        }
    }
}
