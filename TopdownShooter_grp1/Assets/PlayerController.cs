using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    float speed = 0.05f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxisRaw("Horizontal");
        float yMovement = Input.GetAxisRaw("Vertical");

        Vector3 toMove = new Vector3(speed * xMovement, speed * yMovement);

        this.transform.Translate(toMove);

        if (this.transform.position.x > 3 || this.transform.position.x < -3)
        {
            this.transform.Translate(new Vector3(-speed * xMovement, 0));
        }

        if (this.transform.position.y > 5 || this.transform.position.y < -5)
        {
            this.transform.Translate(new Vector3(0, -speed * yMovement));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "asteroid")
        {

            Destroy(other.gameObject);
        }

    }

}
