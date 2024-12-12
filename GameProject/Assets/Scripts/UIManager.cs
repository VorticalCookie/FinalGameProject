using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
/*

Author: [Gonzales, Alejandro]
Last Updated: [12/11/2024]
Date Created: [12/5/2024]
[Handles the main menu and gameover scene.]
*/

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement player;
    public TMP_Text goldText;
    public TMP_Text livesText;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = "Gold: " + player.totalGold;
        livesText.text = "Lives: " + player.lives;
    }
  
    /// <summary>
    /// This is going to allow the player to quit at the end.
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }
    
    /// <summary>
    /// This will switch the scenes between the main menu to start the game or gameover screen leading back in the game or main menu.
    /// </summary>
    /// <param name="sceneIndex"></param>
    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }




}

