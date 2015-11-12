using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed = 0.03f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float movementX = Input.GetAxisRaw("Horizontal");
        float movementY = Input.GetAxisRaw("Vertical");

        Vector3 toMove = new Vector3(speed * movementX, speed * movementY);

        this.transform.Translate(toMove);

        if (this.transform.position.x < -3 || this.transform.position.x > 3)
        {
            this.transform.Translate(new Vector3(speed * -movementX, 0));
        }

        if (this.transform.position.y < -5 || this.transform.position.y > 5)
        {
            this.transform.Translate(new Vector3(0, speed * -movementY));
        }

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "asteroid")
        {
            Destroy(coll.gameObject);
        }
    }
}
