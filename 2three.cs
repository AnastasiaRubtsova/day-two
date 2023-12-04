using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the matrix n*n: ");
        int rows = Convert.ToInt32(Console.ReadLine()), cols= rows;
        int[,] matrix = new int[rows, cols];

        for (int i = 1; i < rows; i++)
        {
            matrix[i, 0] = 1;
            for (int j = 1; j < cols; j++)
            {
                matrix[0, j] = 1;
                matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            }
        }
        Console.WriteLine("The resulting matrix: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}