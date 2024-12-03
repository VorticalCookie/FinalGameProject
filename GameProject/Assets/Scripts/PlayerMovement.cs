using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Author: [Espinoza, Marco]
 * Last Updated: [09/22/2001]
 * [Handles the player movement/jump force]
 */

public class PlayerMovement : MonoBehaviour
{



    public float Speed = 5f; // Speed of forward movement
    public float jumpForce = 10f;  // Force applied to ascend
    public float maxJumpSpeed = 7f; // Max upward velocity
    public float gravity = 10f;    // Custom gravity force

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        // Ascend when input is detected
        if (Input.GetKey(KeyCode.Space))
        {
            if (rb.velocity.y < maxJumpSpeed)
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y + jumpForce * Time.deltaTime, rb.velocity.z);
            }
        }
        else
        {
            // Apply custom gravity when not pressing ascend
            if (rb.velocity.y > -maxJumpSpeed)
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y - gravity * Time.deltaTime, rb.velocity.z);
            }
        }
    }
}
