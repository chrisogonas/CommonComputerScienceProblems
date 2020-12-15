using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
    class BalancedBrackets
    {
        static string isBalanced(string s)
        {
            /*
                0. read bracket
                1. for any open brackets, push to stack
                2. for any close bracket:
                    a. peek into stack
                    b. compare with currently read open bracket
                    c. if a == b, pop stack
                    d. if a <> b, return false
                3. repeat steps 0 to 2
                4. if the program terminates with the stack empty,
                        return true
                    otherwise return false
            */

            // (, ), {, }, [, or ].
            Stack sbrackets = new Stack();
            char bracket = default(char); // first char

            for (int i = 0; i < s.Length; i++)
            {
                bracket = s[i];

                switch (bracket)
                {
                    case '(':
                    case '{':
                    case '[':
                        sbrackets.Push(bracket);
                        break;
                    case ')':
                        if (sbrackets.Count == 0)
                        {
                            return "NO";
                        }
                        if (sbrackets.Peek().Equals('('))
                        {
                            sbrackets.Pop();
                        }
                        else
                        {
                            return "NO";
                        }
                        break;
                    case '}':
                        if (sbrackets.Count == 0)
                        {
                            return "NO";
                        }
                        if (sbrackets.Peek().Equals('{'))
                        {
                            sbrackets.Pop();
                        }
                        else
                        {
                            return "NO";
                        }
                        break;
                    case ']':
                        if (sbrackets.Count == 0)
                        {
                            return "NO";
                        }
                        if (sbrackets.Peek().Equals('['))
                        {
                            sbrackets.Pop();
                        }
                        else
                        {
                            return "NO";
                        }
                        break;
                    default:
                        return "NO";
                        break;
                }
            }
            if (sbrackets.Count == 0)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
