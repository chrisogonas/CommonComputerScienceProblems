using System;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
    class MergeSort
    {
        public static void PerformMergeSort(int[] arrayA, int[] arrayB)
        {
            int[] arrayC = new int[arrayA.Length + arrayB.Length];
            int al = default(int);
            int bl = default(int);
            int cl = default(int);

            while (al < arrayA.Length && bl < arrayB.Length)
            {
                if(arrayA[al] < arrayB[bl])
                {
                    arrayC[cl++] = arrayA[al++];
                } else
                {
                    arrayC[cl++] = arrayB[bl++];
                }
            }
            
            while (al < arrayA.Length)
            {
                arrayC[cl++] = arrayA[al++];
            }

            while (bl < arrayB.Length)
            {
                arrayC[cl++] = arrayB[al++];
            }

            // display merged array
            Console.WriteLine("Merged Array from { 23, 47, 81, 95 } and { 7, 14, 39, 55, 62, 74 }");
            for (int i = 0; i < arrayC.Length; i++)
            {
                Console.Write($"{arrayC[i]} ");
            }
        }
    }
}
