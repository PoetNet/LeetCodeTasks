using System;

namespace Tasks.Daily.May2024;

public static class MatrixMaxLocalFinder
{
    public static int[][] LargestLocal(int[][] grid)
    {
        int n = grid.Length;

        int[][] result = new int[n - 2][];

        for (int i = 0; i < n - 2; i++)
        {
            result[i] = new int[n - 2];

            for (int j = 0; j < n - 2; j++)
            {
                for (int ii = i; ii < i + 3; ii++)
                {
                    for (int jj = j; jj < j + 3; jj++)
                    {
                        var current = grid[ii][jj];
                        result[i][j] = Math.Max(result[i][j], current);
                    }
                }
            }
        }

        return result;
    }
}
