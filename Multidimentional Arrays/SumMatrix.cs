using System;
using System.Collections.Generic;
using System.Linq;

class SumMatrix
{
    static void Main()
    {
        int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int[,] matrix = new int[sizes[0], sizes[1]];
        int sum = 0;

        for (int i = 0; i < sizes[0]; i++)
        {
            int[] row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            for (int j = 0; j < sizes[1]; j++)
            {
                matrix[i, j] = row[j];
                sum += row[j];
            }
        }

        Console.WriteLine(sizes[0]);
        Console.WriteLine(sizes[1]);
        Console.WriteLine(sum);
    }
}
