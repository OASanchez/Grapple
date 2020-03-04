using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentryController : MonoBehaviour
{
    // THIS IS NOT IMPLEMENTED
    // IT WAS AN IDEA FOR A SENTRY ENEMY THAT ULTIMATELY DID NOT FIT INTO THE GAME
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;
    Vector3 nextPos;

    GameObject sentryBullet;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;

        //Stores GameManager object to gO
        sentryBullet= GameObject.Find("Sentry/Platform/Middle Block");
    }

    // Update is called once per frame
    void Update()
    {
        Move();   
    }
    

    void Move(){
        if(transform.position == pos1.position){
            nextPos = pos2.position;
            Debug.Log("1");
        }

        if(transform.position == pos2.position){
            Move();
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
    private void OnDrawGizmos(){
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
