using UnityEngine;
using System.Collections;

public class StarMovement : MonoBehaviour {

    float baseSpeed = 0.03f;
    float speedVariation = 0.6f;
    float speed;

	// Use this for initialization
	void Start () {

        speed = baseSpeed + Random.value * speedVariation;

        Vector3 startingPosition = new Vector3(Random.Range(-3f, 3f), Random.Range(-5f,5f));

        this.transform.position = startingPosition;

        // Slumpa storlek
        float size = Random.Range(0.01f, 0.08f);
        Vector3 scale = new Vector3(size, size);
        this.transform.localScale = scale;

	}
	
	// Update is called once per frame
	void Update () {
        Vector3 movementVector = new Vector3(0,-speed);

        this.transform.Translate(movementVector);

        if (this.transform.position.y < -5)
        {
            // Re-randomize speed
            speed = baseSpeed + Random.value * speedVariation;

            // Re-randsomize start position
            Vector3 startingPosition = new Vector3(Random.Range(-3f, 3f), 10);

            this.transform.position = startingPosition;

        }


    }
}
