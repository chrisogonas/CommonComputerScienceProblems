using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CommonComputerScienceProblems
{
    /// <summary>
    /// The idea of threaded binary trees is to make inorder traversal faster and do it without stack and without recursion. 
    /// In a simple threaded binary tree, the NULL right pointers are used to store inorder successor. Where-ever a right pointer is NULL, 
    /// it is used to store inorder successor.
    /// </summary>
    class ThreadedBinaryTree
    {
        public TBTNode Root { get; set; }

        //public ThreadedBinaryTree(TBTNode root)
        //{
        //    this.Root = root;
        //}

        /// <summary>
        /// Insert keys into BST
        /// </summary>
        /// <param name="nodePointer"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static TBTNode InsertKey(TBTNode nodePointer, int key)
        {
            if (nodePointer is null)
            {
                TBTNode root = new TBTNode(key);
                return root;
            }
            if (key < nodePointer.Key)
            {
                if (nodePointer.Left is null)
                {
                    nodePointer.Left = new TBTNode(key);
                }
                else
                {
                    InsertKey(nodePointer.Left, key);
                }
            }
            else
            {
                if (nodePointer.Right is null)
                {
                    nodePointer.Right = new TBTNode(key);
                }
                else
                {
                    InsertKey(nodePointer.Right, key);
                }
            }

            return nodePointer;
        }

        /// <summary>
        /// InOrder traversal of the BST
        /// </summary>
        /// <param name="node"></param>
        public static void TraverseInOrder(TBTNode node)
        {
            if (node is null)
            {
                return;
            }

            // In-order traversal of the tree to return an ordered list of nodes
            if (node.Left != null)
            {
                TraverseInOrder(node.Left);
            }
            Console.Write($"{node.Key} ");
            if (node.Right != null)
            {
                TraverseInOrder(node.Right);
            }
        }

        /// <summary>
        /// Traverse TBT - from leftmost child
        /// </summary>
        /// <param name="node"></param>
        public static void TraverseTBTInOrder(TBTNode node)
        {
            if (node is null)
            {
                return;
            }
            TBTNode current = LeftMostNode(node);

            while (current != null)
            {
                if (current.Next != null)
                {
                    Console.WriteLine($"{current.Key} ");
                    current = current.Next;
                }
            }
        }

        /// <summary>
        /// Create ordered queue of the tree nodes in ascending order
        /// </summary>
        /// <param name="qNodes"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public static Queue<TBTNode> CreateQueue(Queue<TBTNode> qNodes, TBTNode node)
        {
            if (node is null)
            {
                return null;
            }

            // In-order traversal of the tree to return an ordered list of nodes for the queue
            if (node.Left != null)
            {
                CreateQueue(qNodes, node.Left);
            }
            qNodes.Enqueue(node);
            if (node.Right != null)
            {
                CreateQueue(qNodes, node.Right);
            }

            return qNodes;
        }

        /// <summary>
        /// Create Threaded BST i.e. TBT
        /// </summary>
        /// <param name="qNodes"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public static TBTNode CreateThreadedBST(Queue<TBTNode> qNodes, TBTNode node)
        {
            if (qNodes is null || node is null)
            {
                return null;
            }

            if (node.Left != null)
            {
                CreateThreadedBST(qNodes, node.Left);
            }

            TBTNode qNode = null;
            if (qNodes.Count > 0)
            {
                qNode = qNodes.Dequeue();
            }
            if (node.Right != null)
            {
                CreateThreadedBST(qNodes, node.Right);
            }
            else
            {
                if (qNodes.Count > 0)
                {
                    node.Next = qNode;
                }
            }

            return node; // new Tuple<TBTNode, Queue<TBTNode>>(node,qNodes);
        }

        private static TBTNode LeftMostNode(TBTNode node)
        {
            while (node != null && node.Left != null)
            {
                node = node.Left;
            }

            return node;
        }
    }

    class TBTNode
    {
        public TBTNode Left { get; set; }
        public TBTNode Right { get; set; }
        public TBTNode Next { get; set; }

        public int Key { get; set; }

        public TBTNode(int key)
        {
            this.Key = key;
        }
    }
}
