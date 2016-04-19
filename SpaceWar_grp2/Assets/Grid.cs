﻿using UnityEngine;
using System.Collections;
using System;

public class Grid : MonoBehaviour
{

    public int sizeX = 3;
    public int sizeY = 3;
    public float sizeOfTile = 0.5f;
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
        Vector3 pos = new Vector3(x * sizeOfTile, 0, y * sizeOfTile);

        obj.transform.position = this.transform.position + pos;

        objects[x, y] = obj;

        obj.transform.SetParent(this.transform);
    }
    
    public void putObjectAt(Vector3 unityPos, GameObject obj)
    {
        Vector3 localPos = unityPos - this.transform.position;

        int x = (int) Math.Round(localPos.x / sizeOfTile);
        int y = (int)Math.Round(localPos.y / sizeOfTile);

        putObjectAt(x, y, obj);
        
    }

    public GameObject getObjectAt(int x, int y)
    {
        if (x < 0 || x >= sizeX || y < 0 || y >= sizeY)
        {
            return null;
        }


        return objects[x, y];
    }

}
