using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    public int sizeX;
    public int sizeY;
    public bool running;

    public Grid grid;
    public Grid nextGrid;
    void Start()
    {
        grid = new Grid(new float[sizeX,sizeY]);
        nextGrid = new Grid(new float[sizeX, sizeY]);
    }
    void FixedUpdate()
    {
        if (running)
        {
            EquilizeGrid();
        }
    }
    public void EquilizeGrid()
    {
        for (int x = 0; x < grid.grid.GetLength(0); x++)
        {
            for (int y = 0; y < grid.grid.GetLength(1); y++)
            {
                EquilizeNode(x, y);
            }
        }
        grid = nextGrid;
    }
    //Makes a node and the nodes directly touching it equal
    void EquilizeNode(int x, int y)
    {
        float temp = grid.GetNode(x, y) / ConnectedNodes(NodeUp(y), NodeDown(y), NodeLeft(x), NodeRight(x));
        grid.SetNode(x, y, temp);
        if (NodeUp(y)) { nextGrid.SetNode(x, y + 1, temp); }
        if (NodeDown(y)) { nextGrid.SetNode(x, y - 1, temp); }
        if (NodeRight(x)) { nextGrid.SetNode(x + 1, y, temp); }
        if (NodeLeft(x)) { nextGrid.SetNode(x - 1, y, temp); }
    }
    float ConnectedNodes(bool up, bool down, bool left, bool right)
    {
        float temp = 5f;
        if (!up) { temp -= 1f; }
        if (!down) { temp -= 1f; }
        if (!right) { temp -= 1f; }
        if (!left) { temp -= 1f; }
        return temp;
    }
    bool NodeUp(int y)
    {
        if (y == grid.grid.GetLength(1) - 1)
        {
            return false;
        }
        return true;
    }
    bool NodeDown(int y)
    {
        if (y == 0)
        {
            return false;
        }
        return true;
    }
    bool NodeLeft(int x)
    {
        if (x == 0)
        {
            return false;
        }
        return true;
    }
    bool NodeRight(int x)
    {
        if (x == grid.grid.GetLength(0) - 1)
        {
            return false;
        }
        return true;
    }
}
