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

    //Comment on fait pour load une sauvegarde? la video n'aide pas
    /*public void Loadgame()
    {

    }
    */

    public void QuitGame()
    {
        Application.Quit();
    }
}