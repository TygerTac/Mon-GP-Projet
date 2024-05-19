using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pause;
    public static bool isPaused;

    //public 

    void Start()
    {
        pause.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused) {
                ContinueGame();
            } else {
                StopGame();
            }
        }
    }

    public void ContinueGame()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    /*
    public void SaveGame()
    {

    }

    public void LoadGame()
    {

    }
    */
    public void StopGame()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}