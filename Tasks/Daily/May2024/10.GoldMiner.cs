﻿namespace Tasks.Daily.May2024;

public class GoldMiner
{
    public int GetMaximumGold(int[][] grid)
    {
        int maxGold = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] != 0)
                {
                    maxGold = Math.Max(maxGold, DFS(grid, i, j));
                }
            }
        }

        return maxGold;
    }
    private int DFS(int[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || 
            j < 0 || j >= grid[0].Length || 
            grid[i][j] == 0)
        {
            return 0;
        }

        int currentGold = grid[i][j];
        grid[i][j] = 0; // Mark as visited

        int maxGold = 0;

        maxGold = Math.Max(maxGold, currentGold + DFS(grid, i + 1, j));
        maxGold = Math.Max(maxGold, currentGold + DFS(grid, i - 1, j));
        maxGold = Math.Max(maxGold, currentGold + DFS(grid, i, j + 1));
        maxGold = Math.Max(maxGold, currentGold + DFS(grid, i, j - 1));

        grid[i][j] = currentGold; // Backtrack

        return maxGold;
    }
}
