﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
    class TreeNode
    {
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public int Data { get; set; }

        public TreeNode(int data)
        {
            this.Data = data;
        }

        public void Insert(int data)
        {
            if (data <= this.Data)
            {
                if (this.Left == null)
                {
                    this.Left = new TreeNode(data);
                }
                else
                {
                    this.Left.Insert(data);
                }
            }
            else
            {
                if (this.Right == null)
                {
                    this.Right = new TreeNode(data);
                }
                else
                {
                    this.Right.Insert(data);
                }
            }
        }

        public bool Contains(int data)
        {
            if (this.Data == data) { return true; }
            if (data < this.Data)
            {
                if (this.Left == null)
                {
                    return false;
                }
                else
                {
                    return this.Left.Contains(data);
                }
            }
            else
            {
                if (this.Right == null)
                {
                    return false;
                }
                else
                {
                    return this.Right.Contains(data);
                }
            }

        }

        /// <summary>
        /// get minimum value of BST
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static int GetMinimumValue(TreeNode node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node.Data;
        }

        /// <summary>
        /// get maximum value of BST
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static int GetMaximumValue(TreeNode node)
        {
            while (node.Right != null)
            {
                node = node.Right;
            }

            return node.Data;
        }

        public void InOrderTraverse()
        {
            if (this.Left != null)
            {
                this.Left.InOrderTraverse();
            }
            Console.Write($"{this.Data} ");
            if (this.Right != null)
            {
                this.Right.InOrderTraverse();
            }
        }
    }
}
