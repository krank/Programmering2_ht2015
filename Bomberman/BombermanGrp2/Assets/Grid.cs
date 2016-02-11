using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

    int sizeX = 3;
    int sizeY = 3;
    float sizeOfTile = 0.5f;
    GameObject[,] objects;

	// Use this for initialization
	void Start () {
        objects = new GameObject[sizeX, sizeY];

	}
	
}
