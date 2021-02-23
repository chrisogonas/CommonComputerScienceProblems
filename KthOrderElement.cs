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
        public static int FindKthElement(int[] arr1, int[] arr2, int m,
                int n, int k, int st1, int st2)
        {
            // In case we have reached end of array 1
            if (st1 == m)
            {
                return arr2[st2 + k - 1];
            }

            // In case we have reached end of array 2
            if (st2 == n)
            {
                return arr1[st1 + k - 1];
            }

            // k should never reach 0 or exceed sizes
            // of arrays
            if (k == 0 || k > (m - st1) + (n - st2))
            {
                return -1;
            }

            // Compare first elements of arrays and return
            if (k == 1)
            {
                return (arr1[st1] < arr2[st2])
                        ? arr1[st1] : arr2[st2];
            }
            int curr = k / 2;

            // Size of array 1 is less than k / 2
            if (curr - 1 >= m - st1)
            {

                // Last element of array 1 is not kth
                // We can directly return the (k - m)th
                // element in array 2
                if (arr1[m - 1] < arr2[st2 + curr - 1])
                {
                    return arr2[st2 + (k - (m - st1) - 1)];
                }
                else
                {
                    return FindKthElement(arr1, arr2, m, n, k - curr,
                            st1, st2 + curr);
                }
            }

            // Size of array 2 is less than k / 2
            if (curr - 1 >= n - st2)
            {
                if (arr2[n - 1] < arr1[st1 + curr - 1])
                {
                    return arr1[st1 + (k - (n - st2) - 1)];
                }
                else
                {
                    return FindKthElement(arr1, arr2, m, n, k - curr,
                            st1 + curr, st2);
                }
            }
            else

            // Normal comparison, move starting index
            // of one array k / 2 to the right
            if (arr1[curr + st1 - 1] < arr2[curr + st2 - 1])
            {
                return FindKthElement(arr1, arr2, m, n, k - curr,
                        st1 + curr, st2);
            }
            else
            {
                return FindKthElement(arr1, arr2, m, n, k - curr,
                        st1, st2 + curr);
            }
        }
    }
}
