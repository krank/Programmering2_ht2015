using UnityEngine;
using System.Collections;

public class GameGrid : Grid
{


    public override void Generate()
    {
        for (int y = 0; y < sizeY; y++)
        {
            for (int x = 0; x < sizeX; x++)
            {
                /*x == 0 || 
                    y == 0 ||
                    x == sizeX -1 ||
                    y == sizeY -1 ||
                    (x % 2 == 0 && y % 2 == 0*/


                if (x == 0 || 
                    y == 0 ||
                    x == sizeX -1 ||
                    y == sizeY -1 ||
                    (x % 2 == 0 && y % 2 == 0)
                    )
                {
                    GameObject thing = (GameObject)Instantiate(prefab);

                    putObjectAt(x, y, thing);
                }
            }
        }
    }
}
