using System;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
    class GetLinkNodeDataFromTail
    {
        static int getNode(Node head, int positionFromTail)
        {
            Node tempNode = head;
            int len = 0;
            int data = 0;

            while (tempNode != null)
            {
                tempNode = tempNode.next;
                if (tempNode != null) { len++; }
            }

            int posn = len - positionFromTail;
            tempNode = head; // re-initialize head
            while (tempNode != null && posn >= 0)
            {
                if (posn == 0)
                {
                    data = tempNode.Data;
                    break;
                }
                posn--;
                tempNode = tempNode.next;
            }

            return data;
        }
    }
}
