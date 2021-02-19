using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SharkScript : MonoBehaviour {

    //Declare the score variable and set it to 0
    int score = 0;

    public Text scoreText;

    string myName = "Tiger";

    public Text nameText;

	// Use this for initialization
	void Start () 
	{
        //Initialize the score display
        scoreText.text = "Score: " + score;

        nameText.text = myName + " Shark";
	}
	
	// Update is called once per frame
	void Update () 
	{
		// move the shark according to the inputs
		transform.Translate (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
	}

	void OnCollisionEnter2D (Collision2D otherObject) 
	{
        //Set the score to 1
        score += 1;

        //Update scoreText
        scoreText.text = "Score: " + score;

        //Display the new score
        Debug.Log("Score = " + score);
	}
}
