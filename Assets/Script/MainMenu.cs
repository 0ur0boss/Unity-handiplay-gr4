using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Pour la personne qui reprendra tout voici le lien de la vidéo tuto : https://www.youtube.com/watch?v=4LkiX_XioXg (on sait jamais)

public class MainMenu : MonoBehaviour
{
    public string LevelToLoad;
    public GameObject settingsWindow;
    public GameObject creditsWindow;

    public void StartGame () 
    {
        SceneManager.LoadScene(LevelToLoad);
    }

    public void SettingsButtons () 
    {
        settingsWindow.SetActive(true);
    }

    public void CreditsButtons () 
    {
        creditsWindow.SetActive(true);
    }

    public void CloseSettingsWindow ()
    {
        settingsWindow.SetActive(false);
    }
    public void CloseSettingsWindow ()
    {
        settingsWindow.SetActive(false);
    }

    public void QuitGame () 
    {
        Application.Quit();
    }
    
    
}
