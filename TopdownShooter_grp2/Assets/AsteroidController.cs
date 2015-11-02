using UnityEngine;
using System.Collections;

public class AsteroidController : MonoBehaviour {

    Vector3 toMove;

	// Use this for initialization
	void Start () {
        float speed = Random.Range(0.01f, 0.05f);
        toMove = new Vector3(0, -speed);

        float randomX = Random.Range(-3f, 3f);
        Vector3 newPos = new Vector3(randomX, 5, -1);

        this.transform.position = newPos;

    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(toMove);

        if (this.transform.position.y < -6)
        {
            Destroy(this.gameObject);
        }
	}
}
