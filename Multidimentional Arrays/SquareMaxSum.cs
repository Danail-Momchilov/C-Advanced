using System;
using System.Collections.Generic;
using System.Linq;

class SumMatrix
{
    static void Main()
    {
        int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int[,] matrix = new int[sizes[0], sizes[1]];
        int[,] maxMatrix = new int[2, 2];
        int maxSum = 0;

        for (int i = 0; i < sizes[0]; i++)
        {
            int[] row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int j = 0; j < row.Length; j++)
                matrix[i, j] = row[j];
        }

        for (int i = 0; i < sizes[0] - 1; i++)
        {
            for (int j = 0; j < sizes[1] - 1; j++)
            {
                if (matrix[i, j] + matrix[i, j+1] + matrix[i+1, j] + matrix[i+1, j+1] > maxSum)
                {
                    maxSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    maxMatrix[0, 0] = matrix[i, j];
                    maxMatrix[0, 1] = matrix[i, j+1];
                    maxMatrix[1, 0] = matrix[i+1, j];
                    maxMatrix[1, 1] = matrix[i+1, j+1];
                }
            }
        }

        Console.WriteLine($"{maxMatrix[0, 0]} {maxMatrix[0, 1]}");
        Console.WriteLine($"{maxMatrix[1, 0]} {maxMatrix[1, 1]}");
        Console.WriteLine(maxSum);
    }
}
