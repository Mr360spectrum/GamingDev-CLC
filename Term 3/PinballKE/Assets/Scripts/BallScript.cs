/*
Karter Ence
Pinball - BallScript
2/18/2021
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{

    int score = 0;
    
    public Text scoreText;
    public Text messageText;

    private void Start() {
        scoreText.text = "Score: " + score;
        messageText.text = "";
    }
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log(gameObject.name + " collided with " + other.gameObject.name);
        score++;
        scoreText.text = "Score: " + score;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Game Over!");
        messageText.text = "Game Over!";
    }
}
