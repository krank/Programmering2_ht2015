using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

    public float tileSize = 0.5f;
    public int sizeX = 3;
    public int sizeY = 3;

    GameObject[,] objects;

    

	// Use this for initialization
	void Start () {
        objects = new GameObject[sizeX, sizeY];
        Generate();
	}

    public virtual void Generate()
    {

    }

    public Vector3 GetUnityPos(int gridX, int gridY)
    {
        float x = gridX * tileSize + this.transform.position.x;
        float y = gridY * tileSize + this.transform.position.y;

        return new Vector3(x, y);
    }

    public void PutObject(int x, int y, GameObject obj)
    {
        objects[x, y] = obj;

        Vector3 pos = GetUnityPos(x, y);
        obj.transform.position = pos;

        obj.transform.SetParent(this.transform);

    }

}
