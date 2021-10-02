using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject PauseMenu;

    void Start()
    {
        Time.timeScale = 1f;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        Paused = false;
        PauseMenu.SetActive(false);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        Paused = true;
        PauseMenu.SetActive(true);
    }
    
    public void PauseClic()
    {
        if (Paused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
