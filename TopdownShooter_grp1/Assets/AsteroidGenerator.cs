using UnityEngine;
using System.Collections;

public class AsteroidGenerator : MonoBehaviour
{

    float timer = 2;

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
            timer = Random.Range(0.5f, 2f);
            Debug.Log("Hello");

            Destroy(this);
            Debug.Log("heeeey");

        }
    }
}
