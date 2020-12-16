using System;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
    class IcecreamParlor
    {
        /*
            1. create a dictionary of 2 integers
                - <remainder-key, location-array-index>
            2. run through the array
            3. subtract array item from total fees
            4. check if result from 3 is a key in the dictionary in 1
            5. if true in 4, return an array of:
                - value from dictionary
                - current array index
        */

        // Complete the icecreamParlor function below.
        public static int[] GetMaxPurchase(int m, int[] arr)
        {
            Dictionary<int, int> remainders = new Dictionary<int, int>();
            int[] items = new int[2];

            for (int i = 0; i < arr.Length; i++)
            {
                if (remainders.ContainsKey(m - arr[i]))
                {
                    items[0] = remainders[m - arr[i]] + 1;
                    items[1] = i + 1;
                    break;
                }
                else
                {
                    if(!remainders.ContainsKey(arr[i]))
                    {
                        remainders.Add(arr[i], i);
                    }
                }
            }

            return items;
        }
    }
}
