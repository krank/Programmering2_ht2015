using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour
{

    public int sizeX = 3;
    public int sizeY = 3;
    float sizeOfTile = 0.5f;
    GameObject[,] objects;

    public GameObject prefab;

    // Use this for initialization
    void Start()
    {
        objects = new GameObject[sizeX, sizeY];


        Generate();
    }

    public virtual void Generate()
    {

    }

    public void putObjectAt(int x, int y, GameObject obj)
    {
        Vector3 pos = new Vector3(x * sizeOfTile, y * sizeOfTile);

        obj.transform.position = this.transform.position + pos;

        objects[x, y] = obj;

        obj.transform.SetParent(this.transform);
    }

}
