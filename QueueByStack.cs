using System;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
    class QueueByStack
    {
        /*
            1. create 2 stacks
                1. stack to contain queue items
                2. stack to temporarily hold queue items during printing of the head
            2. enqueue - do a stack push
            3. dequeue - refer to 1 above - for printing and for dequeueing
        */
        static Stack<int> mainQueue = new Stack<int>();
        static Stack<int> tempQueue = new Stack<int>();

        public QueueByStack()
        {
            for (int i = 0; i < 15; i++)
            {
                mainQueue.Push(i);
            }
        }

        public static void OperateQueue()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your                
             * class should be named Solution 
            */
            Console.Write("Enter a command and press ENTER: ");
            string input = Console.ReadLine();
            string[] inputarray = input.Split(' ');
            int cinput = Convert.ToInt32(inputarray[0]);
            
            switch (cinput)
            {
                case 1:
                    if (inputarray.Length != 2)
                    {
                        Console.WriteLine("Command not correctly formed!");
                        return;
                    }
                    Enqueue(Convert.ToInt32(inputarray[1]));
                    break;
                case 2:
                    if (mainQueue.Count > 0)
                    {
                        Dequeue();
                    }
                    else
                    {
                        Console.WriteLine("Queue is empty!");
                    }
                    break;
                case 3:
                    if (mainQueue.Count > 0)
                    {
                        PrintHead();
                    }
                    else
                    {
                        Console.WriteLine("Queue is empty!");
                    }
                    break;
                case 4:
                    if (mainQueue.Count > 0)
                    {
                        PrintAll();
                    }
                    else
                    {
                        Console.WriteLine("Queue is empty!");
                    }
                    break;

                default:
                    Console.WriteLine("Command not recognized!");
                    break;
            }
        }

        static void Enqueue(int item)
        {
            mainQueue.Push(item);
            Console.WriteLine($"{item} queued successfully!");
        }

        static void Dequeue()
        {
            tempQueue = new Stack<int>();
            for (int i = 0; i < mainQueue.Count; i++)
            {
                tempQueue.Push(mainQueue.Pop());
            }

            int titem = tempQueue.Pop(); // dequeue

            // return items to main stack
            for (int i = 0; i < tempQueue.Count; i++)
            {
                mainQueue.Push(tempQueue.Pop());
            }

            Console.WriteLine($"{titem} removed successfully!");
        }

        static void PrintHead()
        {
            tempQueue = new Stack<int>();
            for (int i = 0; i < mainQueue.Count; i++)
            {
                tempQueue.Push(mainQueue.Pop());
            }

            //Console.WriteLine($"{tempQueue.Peek()}");
            Console.WriteLine($"{tempQueue.Peek()} printed successfully!");

            // return items to main stack
            for (int i = 0; i < tempQueue.Count; i++)
            {
                mainQueue.Push(tempQueue.Pop());
            }

        }

        static void PrintAll()
        {
            tempQueue = new Stack<int>();
            for (int i = 0; i < mainQueue.Count; i++)
            {
                tempQueue.Push(mainQueue.Pop());
            }

            // return items to main stack
            int iitem = 0;
            for (int i = 0; i < tempQueue.Count; i++)
            {
                iitem = tempQueue.Pop();
                Console.WriteLine($"{iitem}");
                mainQueue.Push(iitem);
            }

        }

    }
}