using UnityEngine;
using System.Collections;

public class TileController : MonoBehaviour {

    Color ordinary = Color.gray;
    Color mouseOver = Color.magenta;
    Color canMove = Color.green;
    Color cantMove = Color.red;

    void Start()
    {
        Renderer r = this.GetComponent<Renderer>();

        r.material.color = ordinary;
    } 

    void OnMouseEnter()
    {
        Renderer r = this.GetComponent<Renderer>();

        r.material.color = mouseOver;
    }

    void OnMouseExit()
    {
        Renderer r = this.GetComponent<Renderer>();

        r.material.color = ordinary;
    }
	
}
