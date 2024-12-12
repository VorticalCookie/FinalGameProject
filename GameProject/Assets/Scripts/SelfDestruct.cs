using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
  * Author: [Espinoza, Marco]
  * Last Updated: [12/11/2024]
  * Date Created: [12/7/2024]
  * [Destroys the game object after a set number of seconds]
  */

public class SelfDestruct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10f);//Destroys game object after 10 seconds
    }

    
}
