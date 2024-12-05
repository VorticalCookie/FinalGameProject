using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
   * Author: [Espinoza, Marco]
   * Last Updated: [12/5/2024]
   * Date Created: [12/5/2024]
   * [Handles the up and down movement]
   */

public class UpAndDown : MonoBehaviour
{
    public float speed = 2f;        // Speed of up and down movement
    public float distance = 4f;     // How far the object moves up and down
    public float horizontalSpeed = 5f; // Speed of horizontal movement, should match MoveRightSpeed.


    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the Y offset 
        float yOffset = Mathf.Sin(Time.time * speed) * distance;

        // Apply the offset to the object's position, including horizontal movement
        transform.position = startPosition + new Vector3(horizontalSpeed * Time.time, yOffset, 0f);
    }
}
