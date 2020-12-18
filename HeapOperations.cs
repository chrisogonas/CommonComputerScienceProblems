using System;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
    class HeapOperations
    {
        /// <summary>
        /// Display heap items
        /// </summary>
        /// <param name="array">heap array</param>
        /// <param name="heapSize">heap size</param>
        public static void PrintHeap(int[] array, int heapSize)
        {
            for (int i = 0; i < heapSize; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        /// <summary>
        /// Insert Node into heap
        /// </summary>
        /// <param name="array">heap array</param>
        /// <param name="heapSize">heap size</param>
        /// <param name="key">item to insert</param>
        public static int[] InsertNode(int[] array, int heapSize, int key)
        {
            /*
             * 1. insert leftmost i.e. last array item
             * 2. heapify
             */

            // increase heap size by 1
            heapSize++;

            // insert item
            array[heapSize - 1] = key;

            // heapify
            return HeapifyOnInsert(array, heapSize, heapSize - 1);
        }

        /// <summary>
        /// heapify
        /// </summary>
        /// <param name="array">heap array</param>
        /// <param name="heapSize">heap size</param>
        /// <param name="rootIndex">heap root - largest item for max-heap; smallest item for min-heap</param>
        public static int[] HeapifyOnInsert(int[] array, int heapSize, int childIndex)
        {
            int parentIndex = (childIndex - 1) / 2; // get parent

            if (array[parentIndex] > 0)
            {
                if (array[parentIndex] < array[childIndex])
                {
                    int temp = array[childIndex];
                    array[childIndex] = array[parentIndex];
                    array[parentIndex] = temp;

                    // recursively heapify then parent node
                    HeapifyOnInsert(array, heapSize, parentIndex);
                }
            }

            return array;
        }

        /// <summary>
        /// heapify
        /// </summary>
        /// <param name="array">heap array</param>
        /// <param name="heapSize">heap size</param>
        /// <param name="rootIndex">heap root - largest item for max-heap; smallest item for min-heap</param>
        public static int[] HeapifyOnDelete(int[] array, int heapSize, int rootIndex)
        {
            /*
             * a. compare root/parent with children; if less, swap with largest child
             * b. repeat (a.) above till heap meets requirements
             */

            int largest = rootIndex; // index of largest item at root
            int leftIndex = 2 * rootIndex + 1; // left child
            int rightIndex = 2 * rootIndex + 2; // right child

            // is left larger than root
            if (leftIndex < heapSize && array[leftIndex] > array[largest])
            {
                largest = leftIndex;
            }

            // if right is largest
            if (rightIndex < heapSize && array[rightIndex] > array[largest])
            {
                largest = rightIndex;
            }

            // swap if largest is not at root
            if (largest != rootIndex)
            {
                int temp = array[rootIndex];
                array[rootIndex] = array[largest];
                array[largest] = temp;

                // recursively heapify
                HeapifyOnDelete(array, heapSize, largest);
            }

            return array;
        }

        /// <summary>
        /// delete root of heap
        /// </summary>
        /// <param name="array">heap array</param>
        /// <param name="heapSize">heap size</param>
        /// <returns>new heap size</returns>
        public int DeleteRoot(int[] array, int heapSize)
        {
            array[0] = array[array.Length - 1]; // replace root with the last item of the heap

            // reduce heap size
            heapSize--;

            // heapify the root node
            HeapifyOnDelete(array, heapSize, 0);

            return heapSize;
        }

    }
}
