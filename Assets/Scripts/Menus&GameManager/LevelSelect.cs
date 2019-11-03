using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void FirstLevel()
    {
        SceneManager.LoadScene("FirstScene");
    }

    public void SecondLevel()
    {
        SceneManager.LoadScene("SecondScene");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
