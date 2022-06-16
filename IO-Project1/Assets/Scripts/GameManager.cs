using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Canvas gameOverMenu;
    public Text gameoverMenuScore;
    public float delay = 1f;
    public Text score;

    

    private void Start()
    {
        score.text = "0";
    }

    public void ScoreIncrease()
    {
        int intScore = int.Parse(score.text) + 1;
        score.text = intScore.ToString();
    }

    public void GameOver()
    {
        Time.timeScale = 0; 
        Invoke("GameOverMenu", delay);
        
    }
    public void GameOverMenu()
    {
        gameOverMenu.gameObject.SetActive(true);
        gameoverMenuScore.text = score.text;
    } 

    

    

    
}
