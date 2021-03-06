﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 2f;
    public GameObject bombPrefab;

    private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float xAxis = Input.GetAxisRaw("Horizontal");
        float yAxis = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(xAxis, yAxis) * speed * Time.deltaTime;

        //this.transform.Translate(movement);

        rigidBody.position += movement;

        float fire = Input.GetAxisRaw("Fire1");

        if (fire != 0)
        {
            Instantiate(bombPrefab, this.transform.position, Quaternion.identity);
        }

	}
}
