using UnityEngine;
using System.Collections;

public class GrassGrid : Grid {

    public void Generate()
    {
        for (int y = 0; y < sizeY; y++)
        {
            for (int x = 0; x < sizeX; x++)
            {

                GameObject thing = (GameObject)Instantiate(prefab);

                putObjectAt(x, y, thing);

            }
        }
    }

}
