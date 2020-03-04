using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Bool to check for restart
    public static bool restarted;

    // When starting GameOver, pause the game
    public void Start()
    {
        Time.timeScale = 0;
    }

    // Upon restart via pause or game over, set restart to true, restart the scene and all its assets, and unpause the game
    public void Retry()
    {
        restarted = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    // Quit button function that will exit the game
    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}