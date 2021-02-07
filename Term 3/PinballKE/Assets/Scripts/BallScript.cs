using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log(gameObject.name + " collided with " + other.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Game Over!");
    }
}
