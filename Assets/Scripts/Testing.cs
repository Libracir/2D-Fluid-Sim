using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public GridSystem gridSystem;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gridSystem.running)
            {
                gridSystem.running = false;
            }
            else if (!gridSystem.running)
            {
                gridSystem.running = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            gridSystem.nextGrid.DebugAll();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gridSystem.grid.SetNode(0, 0, 100);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gridSystem.EquilizeGrid();
        }
    }
}
