using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int flowersCollected = 0;
    public static int flowersPresent = 0;
    public static string endResult;

    Text scoreText;

    // Start is called before the first frame update
    void Awake()
    {
        scoreText = GetComponent<Text> ();
        // If game has been restarted, the player has collected no flowers
        if (GameOver.restarted == true || NextLevel.restarted == true)
        {
            flowersCollected = 0;
            flowersPresent = 0;
            GameOver.restarted = false;
            NextLevel.restarted = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        endResult = flowersCollected + " / " + flowersPresent;
        scoreText.text = endResult;
    }
}
