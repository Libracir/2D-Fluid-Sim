using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    private float[,] grid;

    public Grid(float[,] grid)
    {
        this.grid = grid;
    }
    public float GetNode(int x, int y) 
    {
        return grid[x, y];
    }
    public void SetNode(int x, int y, float value)
    {
        grid[x, y] = value;
    }
    public void SetAll(float value)
    {
        for (int x = 0; x < grid.GetLength(0); x++)
        {
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                grid[x, y] = value;
            }
        }
    }
    public void DebugAll()
    {
        {
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    Debug.Log(grid[x, y]);
                }
            }
        }
    }
}
