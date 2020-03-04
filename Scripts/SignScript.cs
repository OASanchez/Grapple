using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignScript : MonoBehaviour
{
    [SerializeField]
    Canvas textCanvas;

    // Assigns the sign a canvas
    void Start()
    {
        textCanvas.enabled = false;
    }

    // Show the canvas when the player touches the sign
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            textCanvas.enabled = true;
        }
    }

    // Remove it when they are no longer touching it
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            textCanvas.enabled = false;
        }
    }
}
