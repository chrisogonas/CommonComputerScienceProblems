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
            //MergeSort.PerformMergeSort(new int[] { 23, 47, 81, 95 }, new int[] { 7, 14, 39, 55, 62, 74 });

            // Tree node test
            //TreeNode node = new TreeNode(10);
            //node.InsertNode(8);
            //node.InsertNode(5);
            //node.InsertNode(15);
            //Console.WriteLine(node.Contains(20));
            //Console.WriteLine(node.Contains(8));
            //node.InOrderTraverse();

            //int[] aa = new int[] { 23, 47, 81, 95 };
            //int[] bb = new int[6];
            //Array.Copy(aa, bb, 4);

            // heaps
            // Array representation of Max-Heap 
            //     10 
            //    /  \ 
            //   5    3 
            //  / \ 
            // 2   4 
            int[] array = new int[100];
            int[] array1 = new int[] { 10, 5, 3, 2, 4 };
            Array.Copy(array1, array, array1.Length);

            int n = 5;
            int key = 15;

            Console.WriteLine("Before insert:");
            HeapOperations.PrintHeap(array, n);

            int[] array2 = HeapOperations.InsertNode(array, n, key);

            Console.WriteLine();
            Console.WriteLine("After insert:");

            HeapOperations.PrintHeap(array, 6);

            // Final Heap will be: 
            //     15 
            //    /   \ 
            //   5     10 
            //  / \   / 
            // 2   4 3 
        }
    }
}
