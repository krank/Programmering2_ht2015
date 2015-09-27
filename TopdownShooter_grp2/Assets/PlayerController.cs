using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Yay! Jag finns!");
	}
	
	// Update is called once per frame
	void Update () {

        float speed = 0.03f;

        float movementX = Input.GetAxisRaw("Horizontal");

        Vector3 toMove = new Vector3(speed * movementX,0);

        this.transform.Translate(toMove);

	}
}
