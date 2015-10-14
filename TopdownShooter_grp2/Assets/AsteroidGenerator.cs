using UnityEngine;
using System.Collections;

public class AsteroidGenerator : MonoBehaviour {

    public GameObject asteroid;

    float timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > 2)
        {
            timer = 0;
            Instantiate(asteroid);
        }
	}
}
