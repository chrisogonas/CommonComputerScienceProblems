using System;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
    class Palindrome
    {
        // cases
        // 1. one character - return true
        // > 1
        // loop and read from start and end same time
        // - compare characters from each end
        // - if(all are similar) return true
        // - else return false

        public static bool CheckPalindrome(string pal)
        {
            // base case
            if (pal.Length == 1) { return true; }
            if (pal.Length == 0) { return false; }

            int palLen = pal.Length - 1;

            for (int i = 0; i < pal.Length; i++)
            {
                if (pal[i] != pal[palLen])
                {
                    return false;
                }
                if (pal.Length % 2 == 0)
                {
                    if (i + 1 == palLen)
                    {
                        if (pal[i] == pal[palLen])
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    if (i + 1 == palLen - 1)
                    {
                        return true;
                    }
                }

                --palLen;
            }

            return false;
        }
    }
}