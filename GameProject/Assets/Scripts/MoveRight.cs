using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 /*
  * Author: [Espinoza, Marco]
  * Last Updated: [12/5/2024]
  * Date Created: [12/5/2024]
  * [Basic script that moves the scene right]
  */

public class MoveRight : MonoBehaviour
{
    public float speed = 5f; // Speed of the movement

    void Update()
    {
        // Move the object to the right
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
