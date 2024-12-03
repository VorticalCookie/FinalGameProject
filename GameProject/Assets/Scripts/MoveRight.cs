using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float speed = 5f; // Speed of the movement

    void Update()
    {
        // Move the object to the left
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
