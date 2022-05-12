using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    public int sizeX;
    public int sizeY;
    Grid grid;
    void Start()
    {
        grid = new Grid(new float[sizeX,sizeY]);
    }
    void Update()
    {
        
    }

    //Makes a node and the four nodes directly touching it equal
    void EquilizeNodes(int x, int y)
    {
        float temp = grid.GetNode(x, y) / 5f;
        grid.SetNode(x ,y ,temp);
        grid.SetNode(x+1, y, temp);
        grid.SetNode(x-1, y, temp);
        grid.SetNode(x, y+1, temp);
        grid.SetNode(x, y-1, temp);
    }
}
