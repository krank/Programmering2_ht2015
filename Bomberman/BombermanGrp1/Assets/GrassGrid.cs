using UnityEngine;
using System.Collections;

public class GrassGrid : Grid {

    public GameObject grassTilePrefab;

    public override void Generate()
    {
        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizeY; y++)
            {

                GameObject testTile = Instantiate(grassTilePrefab);

                PutObject(x, y, testTile);
            }
        }



    }

}
