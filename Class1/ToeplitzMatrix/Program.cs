using System;

namespace ToeplitzMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            ToeplitzMatrix toeplitzMatrix = new ToeplitzMatrix(matrix);
            Console.WriteLine("Is Toeplitz Matrix: " + toeplitzMatrix.IsToeplitzMatrix().ToString());
        }
    }

    public class ToeplitzMatrix
    {
        private int[,] matrix;

        public ToeplitzMatrix(int[ ,] inputMatrix)
        {
            this.matrix = inputMatrix;
        }

        public bool IsToeplitzMatrix()
        {
            for (int i = 1; i < matrix.GetLength(0); i++)
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != matrix[i - 1, j - 1]) 
                        return false;
                }
            return true;
        }
    }
}
