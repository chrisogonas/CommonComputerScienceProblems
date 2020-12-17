using System;
using System.Collections;
using System.Collections.Generic;

namespace CommonComputerScienceProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, int> ddd = new Dictionary<int, int>();
            //ddd.Add(2, 4);
            //int itx = ddd[2];
            //string abcd = Console.ReadLine();
            //Hashtable mychars = new Hashtable();
            //HashSet<char> mySet = new HashSet<char>();
            //Stack stack = new Stack();
            //stack.Push("aaa");
            //string abc = stack.Peek().ToString();

            //mychars.Add('(', '(');
            //mychars.Add('(', '(');
            //mychars.Add('(', '(');
            //Console.WriteLine("Hello World!");
            //QueueByStack qbs = new QueueByStack();

            //do
            //{
            //    QueueByStack.OperateQueue();
            //} while (true);

            //IcecreamParlor icecreamParlor = new IcecreamParlor();
            //IcecreamParlor.GetMaxPurchase(4, new int[] { 1, 4, 5, 1, 3, 2 });
            MergeSort.PerformMergeSort(new int[] { 23, 47, 81, 95 }, new int[] { 7, 14, 39, 55, 62, 74 });
        }
    }
}
