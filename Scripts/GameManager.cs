using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 4 Lives unless stated otherwise
    public int livesLeft = 4;

    public Transform spawnPos;

    [SerializeField]
    private GameObject gameOverUI;

    GameObject Player;

    // When starting, turn off gameOverUI, find the player, and spawn them
    void Awake(){
        gameOverUI.SetActive(false);
        Player = GameObject.Find("Player");
        Player.transform.position = spawnPos.transform.position;
    }

    // An update will occur when out of lives and pop up the gameOverUI
    void Update() 
    {
        GameOver();
    }

    private void GameOver(){
        if(livesLeft == 0){
            Debug.Log("GameOver");
            gameOverUI.SetActive(true);
        }
    }
}