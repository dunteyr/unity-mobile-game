using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    Scene currentScene;
    string currentSceneName;
    public static bool gameIsPaused;
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseButton()
    {
        pauseMenu.SetActive(true);
        gameIsPaused = true;
        Time.timeScale = 0f;
    }

    public void ResumeButton()
    {
        pauseMenu.SetActive(false);
        gameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void RestartButton()
    {
        Time.timeScale = 1f;

        currentScene = SceneManager.GetActiveScene();
        currentSceneName = currentScene.name;
        SceneManager.LoadScene(currentSceneName, LoadSceneMode.Single);
    }

    public void LevelSelectButton()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("LevelSelect");
    }

    public void QuitButton()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu");
    }
}
