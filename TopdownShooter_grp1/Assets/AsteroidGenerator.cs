using UnityEngine;
using System.Collections;

public class AsteroidGenerator : MonoBehaviour
{

    float timer = 2;

    public GameObject asteroid;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = 2;
            Instantiate(asteroid);

        }
    }
}
