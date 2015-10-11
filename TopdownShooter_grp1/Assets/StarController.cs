using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour
{
    float speed;
    Vector3 move;

    // Use this for initialization
    void Start()
    {

        reset(true);

        float size = Random.Range(0.01f, 0.1f);
        Vector3 newSize = new Vector3(size, size);
        this.transform.localScale = newSize;
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.Translate(move);

        if (this.transform.position.y < -5)
        {
            reset(false);
        }
    }

    void reset(bool randomY)
    {
        speed = Random.Range(0.03f, 0.3f);
        move = new Vector3(0, -speed);

        float newX = Random.Range(-3f, 3f);

        float newY;
        if (randomY)
        {
            newY = Random.Range(-5f, 5f);
        }
        else
        {
            newY = 5;
        }

        Vector3 newPos = new Vector3(newX, newY);
        this.transform.position = newPos;
    }
}
