using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManger : MonoBehaviour
{
    public bool gameIsPaused = false;
    public bool inOptions = false;
    public bool tabsOpen = false;
    public static bool died = false;

    public GameObject menuForm;
    public GameObject optionsForm;

    public void Start()
    {
        died = false;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(!inOptions && !died)
            {
                OpenMenu();
            }
        }
    }

    public void PauseButton()
    {
        if(!died && !inOptions)
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
        if (inOptions)
        {
            ExitFromOptions();
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

    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Physics.gravity = new Vector2(0, -20);
        Time.timeScale = 1f;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
        Physics.gravity = new Vector2(0, -20);
    }

    public void GoToOptions()
    {
        PauseGame();
        inOptions = true;
        menuForm.SetActive(false);
        optionsForm.SetActive(true);
    }

    public void ExitFromOptions()
    {
        inOptions = false;
        menuForm.SetActive(true);
        optionsForm.SetActive(false);
    }
}
