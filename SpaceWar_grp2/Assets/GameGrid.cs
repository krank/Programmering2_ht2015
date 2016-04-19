using UnityEngine;
using System.Collections;

public class GameGrid : Grid
{

    public GameObject playerOneShip;

    public override void Generate()
    {
        putObjectAt(0, 0, playerOneShip);

        ShipController sc = playerOneShip.GetComponent<ShipController>();

        sc.gridX = 0;
        sc.gridY = 0;

    }
}
