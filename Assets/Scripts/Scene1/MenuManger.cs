using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManger : MonoBehaviour
{
    public bool gameIsPaused = false;
    public static bool died = false;

    public DataConroller dataConroller;
    public GameObject menuForm;
    void Start()
    {
        ResumeGame(); // somehow on from menu game pause;
    }

    public void Pause()
    {
        if(!died)
        {
            if (!gameIsPaused)
            {
                OpenMenu();
            }
            else
            {
                CloseMenu();
            }
        }
    }

    public void OpenMenu()
    {
        menuForm.SetActive(true);
        PauseGame();
    }


    public void CloseMenu()
    {
        menuForm.SetActive(false);
        ResumeGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        gameIsPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Exit() // doesn't use
    { 

        Debug.LogError("пидорас гнида ебаная всю игру сломал");
    }

    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
