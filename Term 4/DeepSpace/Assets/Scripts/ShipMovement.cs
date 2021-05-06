/* Unity Game Programming
 * Deep Space Project
 * Karter Ence
 * 4/15/2021
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShipMovement : MonoBehaviour 
{
	// adjust this value to change the ship speed
	private float speed = 0.03F;

	// this will hold the elapsed time
	public Text timeText;

	// this will hold the game over message
	public Text messageText;

	// private variable to show when the game is over
	private bool gameOver;

    public bool GameOver
    {
        get {return gameOver;}
    }

    public Timer myTimer;

    public Teleporter porter;

	// Use this for initialization
	void Start () 
	{
        myTimer = new Timer(timeText);

        porter = new Teleporter(Camera.main);
	}
	
	// Update is called once per frame
	void Update () 
	{
		// if the game is not over
		if (!gameOver) 
		{
			// move the space ship
			transform.Translate (Input.GetAxis ("Horizontal") * speed, Input.GetAxis ("Vertical") * speed, 0);

            myTimer.Update();

            porter.Wrap(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		// get the tag on the other object
		string otherTag = otherObject.gameObject.tag;

		// if it is an asteroid
		if (otherTag.Equals ("asteroid")) 
		{
			// game is over
			gameOver = true;
			messageText.text = "Game Over";
		}
	}
}
