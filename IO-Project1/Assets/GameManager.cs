using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Canvas gameOverMenu;
    public float delay = 1f;

    public void GameOver()
    {
        Time.timeScale = 0; 
        Debug.Log("Trigger 1");
        Invoke("GameOverMenu", delay);
        
    }
    public void GameOverMenu()
    {
        gameOverMenu.gameObject.SetActive(true);
    } 

    public void Restart()
    {
        SceneManager.LoadScene("Game01");
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        //SceneManager.LoadScene("Game01");
    }

    
}
