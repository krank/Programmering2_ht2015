using UnityEngine;
using System.Collections;

public class TileController : MonoBehaviour {

    Color ordinary = Color.gray;
    Color mouseOver = Color.magenta;
    Color canMove = Color.green;
    Color cantMove = Color.red;

    Renderer tileRenderer;

    void Start()
    {
        tileRenderer = this.GetComponent<Renderer>();

        tileRenderer.material.color = ordinary;
    } 

    void OnMouseEnter()
    {
        tileRenderer.material.color = mouseOver;
    }

    void OnMouseExit()
    {
        tileRenderer.material.color = ordinary;
    }

    public void ChangeColor(Color newColor)
    {
        ordinary = newColor;
        tileRenderer.material.color = ordinary;
    }
	
}
