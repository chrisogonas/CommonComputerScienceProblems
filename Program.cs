using System;
using System.Collections;
using System.Collections.Generic;

namespace CommonComputerScienceProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable mychars = new Hashtable();
            HashSet<char> mySet = new HashSet<char>();
            Stack stack = new Stack();
            stack.Push("aaa");
            string abc = stack.Peek().ToString();

            mychars.Add('(', '(');
            mychars.Add('(', '(');
            mychars.Add('(', '(');
            Console.WriteLine("Hello World!");
        }
    }
}
