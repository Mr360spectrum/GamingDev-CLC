/* Unity Game Programming
 * Deep Space 2 Project
 * Karter Ence
 * 4/16/2021
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShipBehaviour : MonoBehaviour 
{
	// adjust this value to change the ship speed
	private float speed = 0.03F;

	// this will hold the score text
	public Text scoreText;

	// this will hold the game over message
	public Text messageText;

	// keep track of how many asteroids were hit
	private int score = 0;

	// private variable to show when the game is over
	private bool gameOver;

	// The ship will use this Teleporter object
	Teleporter porter;

	// reference to laser prefab
	public GameObject laserPrefab;

	// reference to laser prefab
	public GameObject asteroidPrefab;

	// Use this for initialization
	void Start () 
	{
		// create a new Teleporter object
		porter = new Teleporter (Camera.main);

		// reset score text
		score = 0;
		scoreText.text = "0";

		// create three starting asteroids
		createAsteroid ();
		createAsteroid ();
		createAsteroid ();

		InvokeRepeating("createAsteroid", 1.0f, 3.0f);

	}
	
	// Update is called once per frame
	void Update () 
	{
		// if the game is not over
		if (!gameOver) 
		{
			// move the space ship in the +X direction 
			// (rotation will adjust direction)
			transform.Translate(speed, 0, 0);

			// Get steering left/right input.  Adjust
			// the 100.0F scale factor to turn faster
			// or slower
			float rotation = Input.GetAxis("Horizontal") * 5.0F;

			// rotate left or right according to current input
			// (rotation will be 0 if no input)
			transform.Rotate(0, 0, -rotation);

			// wrap it around to the other side, if needed
			porter.Wrap (gameObject);

			// if the space key has just been pressed this frame
			if (Input.GetKeyDown("space"))
			{
				// fire a new laser shot
				fireShot();
			}
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

	// public to allow other scripts to update the score
	public void IncreaseScore()
	{
		score++;
		scoreText.text = score.ToString();
	}

	// called to create a new asteroid in a random location
	void createAsteroid()
	{
		// only create new asteroids while the game is in-progress
		if (!gameOver) 
		{
			// calculate starting X and Y coordinates
			// somewhere at the top edge of the main camera area
			float worldHeight = Camera.main.orthographicSize * 2.0F;
			float worldWidth = worldHeight * Camera.main.aspect;

			// we are using top edge as a starting point so asteroid
			// is less likely to appear directly on top of the ship!
			Vector2 position;
			position.x = Random.value * worldWidth - worldWidth / 2.0F; 
			position.y = worldHeight / 2.0F;  // top edge

			Instantiate(asteroidPrefab, new Vector3(position.x, position.y, 0), Quaternion.identity);
		}
	}

	// launch a new laser shot at the current ship's location and direction.
	void fireShot()
	{
		GameObject shot = (GameObject)Instantiate(laserPrefab, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        StartCoroutine(scheduleDestroy(1.0f, shot));
	}

	// this function destroys the target object after the specified delay
    IEnumerator scheduleDestroy(float delay, GameObject target)
    {
        yield return new WaitForSeconds(delay);
        Destroy(target);
    }

}
