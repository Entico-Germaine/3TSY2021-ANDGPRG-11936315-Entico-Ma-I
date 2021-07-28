using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardSpeed = 1000f;
    public float sideSpeed = 500f;

    // Update is called once per frame
    void Update()
    {
        // keeps the player moving forward
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f )
        {
            FindObjectOfType<gameManager>().restartGame();
        }
    }
}
