using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;

    Vector3 nextPos;

    Vector3 moving;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();   
        
    }

    // Keep moving the platform one way or the other until it hits the stopper positions
    // Turn it around and repeat if it does
    void Move(){
        if(transform.position == pos1.position){
            nextPos = pos2.position;
        }

        if(transform.position == pos2.position){
            nextPos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    // Line for movement
    private void OnDrawGizmos(){
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
