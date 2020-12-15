using System;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
    class DetectLinkedListCycle
    {
        static bool hasCycle(Node head)
        {
            HashSet<Node> nodes = new HashSet<Node>();

            if (head == null) { return false; }

            while (head != null)
            {
                if (nodes.Contains(head))
                {
                    return true;
                }
                else
                {
                    nodes.Add(head);
                }

                head = head.next;
            }

            return false;

        }
    }
}
