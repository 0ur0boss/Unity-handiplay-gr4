using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Pour la personne qui reprendra tout voici le lien de la vidéo tuto : https://www.youtube.com/watch?v=4LkiX_XioXg (on sait jamais)

public class MainMenu : MonoBehaviour
{
    public string MainCamera;

    public void StartGame () 
    {
        SceneManager.LoadScene(MainCamera);
    }

    public void OptionsButtons () 
    {
    
    }

    public void CreditsButtons () 
    {

    }

    public void QuitGame () 
    {
        Application.Quit();
    }
    
    
}
