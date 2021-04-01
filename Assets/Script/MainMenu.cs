using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class MainMenu : MonoBehaviour
{
    public string LevelToLoad;
    public GameObject menuWindow;
    public GameObject settingsWindow;
    public GameObject creditsWindow;
    public GameObject menuFirstButton, optionFirstButton, optionClosedButton, creditsFirstButton;


    public void BackToMenuWindow ()
    {
        if (menuWindow.activeInHierarchy)
        {
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(menuFirstButton);
        }
    }

    public void StartGame () 
    {
        SceneManager.LoadScene(LevelToLoad);
    }

    public void SettingsButtons () 
    {
        settingsWindow.SetActive(true);
        menuWindow.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionFirstButton);
    }

    public void CreditsButtons () 
    {
        creditsWindow.SetActive(true);
        menuWindow.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(creditsFirstButton);
    }

    /*public void CloseSettingsWindow ()
    {
        settingsWindow.SetActive(false);
        menuWindow.SetActive(true);
        BackToMenuWindow();
    }
    public void CloseCreditsWindow ()
    {
<<<<<<< HEAD:Assets/MainMenu.cs
        creditsWindow.SetActive(false);
        menuWindow.SetActive(true);
        BackToMenuWindow();
    }
=======
        settingsWindow.SetActive(false);
    }*/
>>>>>>> 965e56dac12d2a03846596a78143f83d30845b76:Assets/Script/MainMenu.cs

    public void QuitGame () 
    {
        Application.Quit();
    }
}