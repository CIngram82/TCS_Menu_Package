using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float loadLevelAfter;

    // Start is called before the first frame update
    void Start()
    {
        if(loadLevelAfter <= 0)
        {
            // Display error if numer is less than 0
            Debug.Log("Level auto load disabled");
        }
        else
        {
            // Load the next level after a number of seconds
            Invoke("LoadNextLevel",loadLevelAfter);
        }
    }
    public void LoadNextLevel()
    {
        //Get current scene number
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        //Load the scene after this one
        SceneManager.LoadScene(currentScene + 1);

    }
   
    public void LoadLevelByName(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Application.Quit();
    }
}