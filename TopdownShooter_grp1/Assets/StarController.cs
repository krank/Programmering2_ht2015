using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour
{
    float speed = 0.03f;

    // Use this for initialization
    void Start()
    {
        speed = Random.Range(0.03f, 0.3f);

        float randomX = Random.Range(-2.5f, 2.5f);
        float randomY = Random.Range(-5, 5);
        Vector3 newPos = new Vector3(randomX, randomY);

        this.transform.position = newPos;

        float size = Random.Range(0.5f, 1);
        Vector3 newSize = new Vector3(size, size);
        this.transform.localScale = newSize;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0, -speed);
        this.transform.Translate(move);

        if (this.transform.position.y < -5)
        {
            float randomX = Random.Range(-2.5f, 2.5f);
            Vector3 newPos = new Vector3(randomX, 5);
            this.transform.position = newPos;

            speed = Random.Range(0.03f, 0.3f);
        }
    }
}
