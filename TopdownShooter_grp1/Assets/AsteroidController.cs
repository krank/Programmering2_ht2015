using UnityEngine;
using System.Collections;

public class AsteroidController : MonoBehaviour
{

    Vector3 toMove = new Vector3(0, -0.03f);

    // Use this for initialization
    void Start()
    {
        float yPos = Random.Range(-2f, 2f);
        Vector3 firstPos = new Vector3(yPos, 5);

        this.transform.position = firstPos;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(toMove);

        if (this.transform.position.y < -6)
        {
            Destroy(this.gameObject);
        }
    }
}
