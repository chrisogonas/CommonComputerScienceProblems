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
            //node.Insert(8);
            //node.Insert(5);
            //node.Insert(15);
            //Console.WriteLine(node.Contains(20));
            //Console.WriteLine(node.Contains(8));
            //Console.WriteLine(TreeNode.GetMinimumValue(node));
            //Console.WriteLine(TreeNode.GetMaximumValue(node));
            //node.InOrderTraverse();

            //int[] aa = new int[] { 23, 47, 81, 95 };
            //int[] bb = new int[6];
            //Array.Copy(aa, bb, 4);

            //// heaps
            //// Array representation of Max-Heap 
            ////     10 
            ////    /  \ 
            ////   5    3 
            ////  / \ 
            //// 2   4 
            //int[] array = new int[100];
            //int[] array1 = new int[] { 10, 5, 3, 2, 4 };
            //Array.Copy(array1, array, array1.Length);

            //int n = 5;
            //int key = 15;

            //Console.WriteLine("Before insert:");
            //HeapOperations.PrintHeap(array, n);

            //int[] array2 = HeapOperations.InsertNode(array, n, key);

            //Console.WriteLine();
            //Console.WriteLine("After insert:");

            //HeapOperations.PrintHeap(array, 6);

            //// Final Heap will be: 
            ////     15 
            ////    /   \ 
            ////   5     10 
            ////  / \   / 
            //// 2   4 3 
            ///

            // Palindromes
            //Console.WriteLine(Palindrome.CheckPalindrome("abcsba"));

            // THREADED BINARY TREE
            ThreadedBinaryTree tree = new ThreadedBinaryTree();
            //tree.Root = new TBTNode(1);
            //tree.Root.Left = new TBTNode(2);
            //tree.Root.Right = new TBTNode(3);

            //tree.Root.Left.Left = new TBTNode(4);
            //tree.Root.Left.Right = new TBTNode(5);
            //tree.Root.Right.Left = new TBTNode(6);
            //tree.Root.Right.Right = new TBTNode(7);

            //ThreadedBinaryTree.TraverseInOrder(tree.Root);

            tree.Root = new TBTNode(6);
            ThreadedBinaryTree.InsertKey(tree.Root, 10);
            ThreadedBinaryTree.InsertKey(tree.Root, 3);
            ThreadedBinaryTree.InsertKey(tree.Root, 2);
            ThreadedBinaryTree.InsertKey(tree.Root, 7);
            ThreadedBinaryTree.InsertKey(tree.Root, 4);
            ThreadedBinaryTree.InsertKey(tree.Root, 1);
            ThreadedBinaryTree.InsertKey(tree.Root, 5);
            ThreadedBinaryTree.InsertKey(tree.Root, 9);

            //Queue<TBTNode> qNodes = new Queue<TBTNode>();
            //ThreadedBinaryTree.TraverseInOrder(tree.Root);
            //Queue<TBTNode> qRet = ThreadedBinaryTree.CreateQueue(qNodes, tree.Root);
            TBTNode node = ThreadedBinaryTree.CreateThreadedBST(tree.Root);
            ThreadedBinaryTree.TraverseTBTInOrder(node);
        }
    }
}
