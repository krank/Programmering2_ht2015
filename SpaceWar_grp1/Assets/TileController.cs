using UnityEngine;
using System.Collections;

public class TileController : MonoBehaviour {

    public Color normalColor = Color.gray;
    public Color mouseOverColor = Color.blue;

    private Renderer rend;

	// Use this for initialization
	void Start () {

        rend = this.GetComponent<Renderer>();

        SetColor(normalColor);
	}

    void OnMouseEnter()
    {
        SetColor(mouseOverColor);
    }

    void OnMouseExit()
    {
        SetColor(normalColor);
    }

    void SetColor(Color newColor)
    {
        rend.material.color = newColor;
    }

}
