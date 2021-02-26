using System;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
    /// <summary>
    /// Program heavily borrowed from Geeks for Geeks. See the link below:
    /// https://www.geeksforgeeks.org/k-th-element-two-sorted-arrays/
    /// Given two sorted arrays of size m and n respectively, you are tasked with finding the element that 
    /// would be at the k’th position of the final sorted array.
    /// </summary>
    class KthOrderElement
    {
        public static int FindKthElement(int[] arr1, int m, int[] arr2, int n, int k)
        {
            if (k > (m + n) || k < 1)
                return -1;

            // let m > n
            if (m > n)
                return FindKthElement(arr2, n, arr1, m, k);

            // Check if arr1 is empty returning 
            // k-th element of arr2
            if (m == 0)
                return arr2[k - 1];

            // Check if k = 1 return minimum of first
            // two elements of both arrays
            if (k == 1)
                return Math.Min(arr1[0], arr2[0]);

            // Now the divide and conquer part
            int i = Math.Min(m, k / 2);
            int j = Math.Min(n, k / 2);

            if (arr1[i - 1] > arr2[j - 1])
            {

                // Now we need to find only k-j th element
                // since we have found out the lowest j
                int[] temp1 = new int[n-j];
                Array.Copy(arr2, j, temp1, 0, temp1.Length);
                return FindKthElement(arr1, m, temp1, n - j, k - j);
            }

            // Now we need to find only k-i th element
            // since we have found out the lowest i
            int[] temp2 = new int[k-i]; // Arrays.copyOfRange(arr1, i, m);
            Array.Copy(arr1, i, temp2, 0, temp2.Length);
            return FindKthElement(temp2, m - i, arr2, n, k - i);
        }
    }
}
