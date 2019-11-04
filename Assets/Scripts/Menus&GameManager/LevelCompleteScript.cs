using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteScript : MonoBehaviour
{
    public void NextLevelButton()
    {
        //Ill do this later. Maybe get the scene index + 1? But that could run into
        //some problems later on i dunno.
        Scene currentSceneIndex = SceneManager.GetActiveScene();
        if(currentSceneIndex.buildIndex < 3)
        {
            SceneManager.LoadScene(currentSceneIndex.buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
        

    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
