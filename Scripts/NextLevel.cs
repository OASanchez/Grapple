using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    public static bool restarted;
    [SerializeField]
    Canvas messageCanvas;
    [SerializeField]
    Text scoreText;

    // Start game with the canvas
    public void Start()
    {
        messageCanvas.enabled = false;
    }

    // Load Main Menu Scene
    public void Home()
    {
        SceneManager.LoadScene("Main Menu");
    }

    // Restart game, pass restarted variable, and unpause
    public void Retry()
    {
        restarted = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    // Exit game
    public void QuitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                    Application.Quit();
        #endif
    }

    // Load next scene and unpause game
    public void Next()
    {
        restarted = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    }

    // Pause the game when going to the next level and pop up the next level UI
    void OnTriggerEnter2D(Collider2D theCollision)
    {
        if (theCollision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            messageCanvas.enabled = true;
            scoreText.text = ScoreScript.endResult;
        }
    }
}
