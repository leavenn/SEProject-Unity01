using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public float transitionTime = 1f;
    public Animator transition;
    

    IEnumerator LoadScene(string  scene)
    {
        
        transition.SetTrigger("Start");
        

        yield return new WaitForSecondsRealtime(transitionTime);

        
        SceneManager.LoadScene(scene);
        Time.timeScale = 1f;
    }

    public void StartGame()
    {
        
        StartCoroutine(LoadScene("Game01"));
        
    }
    public void MainMenu()
    {
        StartCoroutine(LoadScene("MainMenu"));
    }

    

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
