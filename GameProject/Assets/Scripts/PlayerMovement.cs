using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Author: [Espinoza, Marco]
 * Last Updated: [12/5/2024]
 * Date Created: [12/3/2024]
 * [Handles the player movement/jump force]
 */

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5f; // Speed of forward movement
    public float jumpForce = 10f;  // Force applied to ascend
    public float maxJumpSpeed = 7f; // Max upward velocity
    public float gravity = 10f;    // Custom gravity force
    public float maxHeight = 9f; // Maximum jump height
    public int lives;
    public int totalGold;

    private Rigidbody rb;
    private float startY; // Store the initial Y position

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startY = transform.position.y; // Initialize startY
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        // Ascend when input is detected and below maxHeight
        if (Input.GetKey(KeyCode.Space) && transform.position.y - startY < maxHeight)
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
