using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Author: [Espinoza, Marco and Barravecchia, Mason]
 * Last Updated: [12/7/2024]
 * Date Created: [12/3/2024]
 * [Handles the player movement/jump force, and Live Count.]
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
    public GameObject background;
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;

    private Rigidbody rb;
    private float startY; // Store the initial Y position

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startY = transform.position.y; // Initialize startY
        StartCoroutine(Level());
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
       // Debug.Log("Player X Position: " + transform.position.x);
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Gold"))
        {
            totalGold += 1;
            Destroy(other.gameObject); // Destroy the gold coin
        }
        ///Bullet Collision and Losing life upon impact.
        if (other.gameObject.CompareTag("Enemy"))
        {
            lives -= 1; ///take off a life
            Destroy(other.gameObject);
            CheckGameOver();
        }

        if (other.gameObject.CompareTag("Health"))
        {
            lives += 1; ///add a life
            Destroy(other.gameObject);
            
        }
    }
    /// <summary>
    /// this function serves as a placeholder to remind me to impliment the game over screen transition.
    /// </summary>
    private void CheckGameOver()
    {
        if (lives <= 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene(2);
        }
    }
    
    /// <summary>
    /// This controls how long the background/level lasts in game.
    /// </summary>
    /// <returns></returns>
    public IEnumerator Level()
    {
        yield return new WaitForSeconds(30);
        background.SetActive(false);
        background1.SetActive(true);
        yield return new WaitForSeconds(45);
        background1.SetActive(false);
        background2.SetActive(true);
        yield return new WaitForSeconds(60);
        background2.SetActive(false);
        background3.SetActive(true);

        //Level 1 Starts at 0:00
        //Level 2 Starts at 0:30
        //Level 3 Starts at 1:15
        //Level 4 Starts at 2:15
    }


}
