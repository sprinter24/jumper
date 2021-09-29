using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManger : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject menuForm;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Pause()
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

    public void Exit()
    {
        Debug.LogError("пидорас гнида ебаная всю игру сломал");
    }
}
