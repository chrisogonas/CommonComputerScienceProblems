using System;
using System.Collections.Generic;
using System.Text;

namespace CommonComputerScienceProblems
{
    class MatrixMultiplication
    {

        /// <summary>
        /// Bruteforce matrix multiplier
        /// </summary>
        /// <param name="A">First Matrix</param>
        /// <param name="B">Second Matrix</param>
        /// <returns>Result Matrix</returns>
        static public int[,] MultiplyMatrix(int[,] A, int[,] B)
        {
            int[,] C = new int[A.Length, B.Length];
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    for (int k = 0; k < B.Length; k++)
                    {

                    }
                }
            }

            return null;
        }
    }
}
