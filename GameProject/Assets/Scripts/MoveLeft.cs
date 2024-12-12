using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 /*
  * Author: [Espinoza, Marco]
  * Last Updated: [12/5/2024]
  * Date Created: [12/5/2024]
  * [Basic script that moves the scene right]
  */

public class MoveLeft : MonoBehaviour
{
    public float speed = 5f; // Speed of the movement

    void Update()
    {
        // Move the object to the left
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
