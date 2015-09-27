using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float speed = 0.05F;

        float playerMovementX = Input.GetAxisRaw("Horizontal");
        float playerMovementY = Input.GetAxisRaw("Vertical");

        Vector3 movementVector = new Vector3();

        /*
        if (playerMovementX < 0 && this.transform.position.x > -3)
        {
            movementVectorX = new Vector3(speed * playerMovementX, 0);
        }
        else if (playerMovementX > 0 && this.transform.position.x < 3)
        {
            movementVectorX = new Vector3(speed * playerMovementX, 0);
        }*/


        movementVector = new Vector3(speed * playerMovementX, speed * playerMovementY);

        this.transform.Translate(movementVector);

        if (this.transform.position.x > 3)
        {
            this.transform.Translate(new Vector3(-speed, 0));
        }

        if (this.transform.position.x < -3)
        {
            this.transform.Translate(new Vector3(speed, 0));
        }

    }
}
