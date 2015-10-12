using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour
{

    float speed;

    // Use this for initialization
    void Start()
    {
        speed = Random.Range(0.03f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0, -speed);
        this.transform.Translate(move);

        if (this.transform.position.y < -5)
        {
            float randomX = Random.Range(-3f, 3f);
            Vector3 newPos = new Vector3(randomX, 5);
            this.transform.position = newPos;

            speed = Random.Range(0.03f, 0.3f);
        }
    }
}
