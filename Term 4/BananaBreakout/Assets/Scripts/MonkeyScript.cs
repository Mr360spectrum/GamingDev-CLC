/* Unity Game Programming
 * Banana Breakout
 * Author name
 * Project date
 */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MonkeyScript : MonoBehaviour 
{
	// Initial movement Speed
	public float speed = 4.0f;

	// score and text display
	private int score = 0;
	public Text scoreText;

	private float paddleWidth;

	// Use this for initialization
	void Start () 
	{
		// reset score and display
		score = 0;
		scoreText.text = "Score: " + score;

		// grab the paddle width for future use
		GameObject paddle = GameObject.Find("Trampoline");
		paddleWidth = paddle.GetComponent<BoxCollider2D> ().size.x;

		// calculate random inital direction for the monkey
		// (1.0F units "up", + or - 0.5F units "left/right"
		Vector2 initialDirection = new Vector2 (Random.value - 0.5F, 1.0F);
		initialDirection.Normalize (); // get unit vector of consistent length 1

		// set initial velocity in the initial direction at starting speed
		GetComponent<Rigidbody2D>().velocity = initialDirection * speed;
	}

	void OnCollisionEnter2D(Collision2D otherObject) 
	{
		// This function is called whenever the ball
		// collides with something

		// Did we hit the trampoline?
		if (otherObject.gameObject.name.Equals("Trampoline") )
		{
			// Calculate direction we'll bounce away from trampoline.
			// If you hit near the left side, you'll bounce towards the left,
			// If you hit near the right side, you'll bounce towards the right,
			// If you hit near the middle, you'll bounce straight up.

			// calculate the difference in X locations of center of mass
			float xDifference = transform.position.x - otherObject.transform.position.x;
			float xDirection = xDifference / paddleWidth;

			// Calculate new direction, normalized to length to 1
			Vector2 dir = new Vector2 (xDirection, 1).normalized;
			
			// Set new velocity equal to new direction * current speed
			GetComponent<Rigidbody2D> ().velocity = dir * speed;

			// Every time we collide with the trampoline, check the Controller
			// script and see if all of the blocks need to be regenerated.
			// If blocks were regenerated, also increase the current monkey
			// speed by a little bit to make the game harder.
			Controller controllerScript = GameObject.Find ("Controller").GetComponent<Controller> ();
			if (controllerScript.CheckRestart ()) 
			{
				speed += 1.0F; // speed up the monkey
			}
		} 
		else if (otherObject.gameObject.CompareTag ("block")) 
		{
			// monkey collided with a block.

			// increase the score
			score++;
			scoreText.text = "Score: " + score;

			// destroy the block
			Destroy (otherObject.gameObject);
		}
	}
}
