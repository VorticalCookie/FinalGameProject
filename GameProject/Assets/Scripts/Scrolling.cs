using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    * Author: [Espinoza, Marco]
    * Last Updated: [12/3/2024]
    * Date Created: [12/3/2024]
    * [Handles the parallax effect]
    */

public class Scrolling : MonoBehaviour
{
    private float length, startPos;// The length of the sprite and its starting position
    public GameObject cam; // Reference to the camera object to track its movement
    public float parallaxEffect; // The parallax effect relative to the camera
    private void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);
        if (temp > startPos + length) startPos += length;
        else if ( temp< startPos - length) startPos -= length;
    }


}
