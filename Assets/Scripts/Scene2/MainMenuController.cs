using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Slider volume;

    public GameObject menu;
    public GameObject options;
    public GameObject credits;

    public Button backToMenu;
    public Button backToOptions;

    void Start()
    {
        volume.value = PlayerPrefs.GetFloat("Volume"); //back button save
    }

    
    void Update()
    {
        
    }

    public void ToOptions()
    {
        menu.SetActive(false);
        options.SetActive(true);
    }

    public void ToCredits()
    {
        options.SetActive(false);
        credits.SetActive(true);
    }

    public void FromOptions()
    {
        options.SetActive(false);
        menu.SetActive(true);
        PlayerPrefs.SetFloat("Volume", volume.value);
    }
    public void FromCredits()
    {
        options.SetActive(true);
        credits.SetActive(false);
    }

}
