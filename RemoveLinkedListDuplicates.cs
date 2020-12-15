using System;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
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
                if (current.next != null)
                {
                    if (current.next.Data == current.Data)
                    {
                        if (current.next.next != null)
                        {
                            current.next = current.next.next; // skip similar node
                        }
                        else
                        {
                            current.next = current.next.next; // skip last similar node
                            break; // end of list
                        }
                    }
                    else
                    { // neighbors are unique
                        current = current.next;
                    }
                }
                else
                {
                    current = current.next; // advance to null if at the end
                }
            }

            return newHead;
        }
    }
}
