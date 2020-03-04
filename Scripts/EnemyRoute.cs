using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoute : MonoBehaviour
{

    public float speed;
    public float distance = 2f;
    private bool movingRight = true;
    public Transform groundDetection;
    public Transform wallDetection;

    // Update is called once per frame
    void Update()
    {
        Route();
    }

    void Route()
    {
        // Movement
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        // Constantly checking for the ground and walls upon update
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        RaycastHit2D wallInfo = Physics2D.Raycast(wallDetection.position, Vector2.positiveInfinity, distance);
        
        // If there is a wall or no more ground, turn around the model and collider, otherwise, keep going
        if(groundInfo.collider == false || wallInfo.collider == true){
            if(movingRight == true){
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            } else{
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }
}
