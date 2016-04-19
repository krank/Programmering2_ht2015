using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour
{

    public TileGrid tileGrid;

    public int gridX;
    public int gridY;

    // Use this for initialization
    void Start()
    {
        CheckValidPositions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckValidPositions()
    {

        GameObject tile1 = tileGrid.getObjectAt(gridX, gridY);
        TileController tc = tile1.GetComponent<TileController>();
        tc.ChangeColor(Color.green);
        Debug.Log("hey?");

    }
}
