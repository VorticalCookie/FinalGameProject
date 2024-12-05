using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    /*
     * Author: [Espinoza, Marco]
     * Last Updated: [12/5/2024]
     * Date Created: [12/5/2024]
     * [Handles the spawning of objects]
     */

    //The variables needed to spawn objects
    public GameObject objectPrefab;
    public float timeBetweenSpawns;
    public float startDelay;


    // Start is called before the first frame update
    void Start()
    {
        //Repeats the same function
        InvokeRepeating("SpawnObject", startDelay, timeBetweenSpawns);
    }

    // Update is called once per frame
    public void SpawnObject()
    {

        //invokes games objects
        Instantiate(objectPrefab, transform.position, objectPrefab.transform.rotation);
    

    }
}



