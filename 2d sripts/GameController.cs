using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// for all game
public class GameController : MonoBehaviour
{   
    
    public GameObject gameOverPanel;
    public GameObject Score;
    
    void Start()
    {
        gameOverPanel.SetActive(false);
        Score.SetActive(true);           
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Score.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene("RaseUp");  // name the scene which u want to restart
    }

    
    public void Quit()
    {
        Application.Quit();
    }
 
}
