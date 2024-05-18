using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuStart : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level01");
    }

    //Comment on fait pour load une sauvegarde? :raised_eyebrows:

    public void QuitGame()
    {
        Application.Quit();
    }
}