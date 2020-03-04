using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    GameObject gO;

    GameManager gM;

    public int waypointLives;

    // Start is called before the first frame update
    void Start()
    {
        InitWaypointChecks();
    }

    public void InitWaypointChecks()
    {
        //Stores GameManager object to gO 
        gO= GameObject.Find("GameManager");
        // Calls GameManager script from GameManager object
        gM = gO.GetComponent<GameManager>();
    }

    // When the player enters the tree collider, set their spawn point to this and replenish their lives
    void OnTriggerEnter2D(Collider2D theCollision)
    {
        if(theCollision.gameObject.tag == "Player" && GameObject.Find("Spawner").transform.position.x < transform.position.x)
        {
            gM.spawnPos.position = transform.position;

            // These lives are set to 4 because waypoints are before and after difficult events
            gM.livesLeft = 4;
        }
    }
}
