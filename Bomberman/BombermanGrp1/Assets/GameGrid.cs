using UnityEngine;
using System.Collections;

public class GameGrid : Grid
{

    public GameObject impassibleTilePrefab;

    public override void Generate()
    {
        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizeY; y++)
            {
                if (x == 0 || x == sizeX - 1 ||
                    y == 0 || y == sizeY - 1 ||
                    (x % 2 == 0 && y % 2 == 0)
                    )
                {

                    GameObject testTile = Instantiate(impassibleTilePrefab);

                    PutObject(x, y, testTile);

                }
            }
        }
    }
}
