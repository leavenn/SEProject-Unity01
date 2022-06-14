using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float delay = 1f;
    public void GameOver()
    {
        Invoke("Restart", delay);
        
    }

    private void Restart()
    {
        SceneManager.LoadScene("Game01");
    }
}
