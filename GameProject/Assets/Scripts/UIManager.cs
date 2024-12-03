using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public void QuitGame()
    {
        Application.Quit();
    }
    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }




}

