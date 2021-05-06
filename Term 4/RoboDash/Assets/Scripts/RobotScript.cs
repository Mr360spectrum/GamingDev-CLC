/* Unity Game Programming
 * RoboDash Project
 * RoboDash Author
 * Project Date
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RobotScript : MonoBehaviour 
{
    Animator robotAnim;

	// public variables to controls the speed
	// of the robot, shots, and jump force
	public float jumpForce = 300.0f;
	public float robotSpeed = 0.1f;
	public float laserSpeed = 20.0f;

	// keep robot on the screen
	PositionClamp spriteClamp;

	// limit the number of jumps before landing
	int numJumps;

	// public variables to hold external references 
	public Text shotsText;
	public GameObject laserPrefab;

	// track number of remaining shots
	int numShots;

	// reference to the main controller script
	ControllerScript controller;

	// reference to this object's Rigidbody2D
	Rigidbody2D rb;

	// Use this for initialization
	void Start () 
	{
        robotAnim = GetComponent<Animator>();

		// calculate min and max X and Y world coordinates for the screen
		float worldHeight = Camera.main.orthographicSize * 2.0F;
		float worldWidth = worldHeight * Camera.main.aspect;

		float xMin = -worldWidth/2.0F;
		float yMin = -worldHeight/2.0F;
		float xMax = worldWidth/2.0F;
		float yMax = worldHeight/2.0F;

		// get this object's Rigidbody2D and store for future use
		rb = GetComponent<Rigidbody2D>();

		// get this sprite renderer 
		Renderer r = GetComponent<Renderer> ();

		// create PositionClamp on camera boundaries
		spriteClamp = new PositionClamp (xMin, yMin, xMax, yMax, r);

		// set initial number of jumps and shots
		numJumps = 3;
		numShots = 3;
		updateShotsText ();

		// get and store reference to ControllerScript for future use
		GameObject controllerObj = GameObject.Find ("Controller");
		controller = controllerObj.GetComponent<ControllerScript> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		// check and see if the game is over
		if (controller.IsGameOver ()) 
		{
			return; // if so, don't do anything
		}

		// if robot currently has any jumps remaining
		if (numJumps > 0) 
		{
			// if user has pressed the up arrow key
			if (Input.GetKeyDown (KeyCode.UpArrow)) 
			{
				// add upwards force and reduce # of remaining jumps
				rb.AddForce (new Vector2 (0, jumpForce));
				numJumps--; 

                //Change to jump animation
                robotAnim.SetInteger("state", 1);
			}
		}

		// if robot currently has available shots
		if (numShots > 0) 
		{
			// if user has pressed the space bar
			if (Input.GetKeyDown (KeyCode.Space)) 
			{
				fireShot (); // shoot!

                //Change to shoot animation
                robotAnim.SetTrigger("shooting");
			}
		}

		// allow user to move robot in the horizontal direction with arrow keys
		transform.Translate (Input.GetAxis ("Horizontal") * robotSpeed, 0, 0);

		// Use the position clamp to limit player's movement to the screen.
		// Also, track the original and possibly new position vector
		// for use as described below.
		Vector3 oldPosition = transform.position;
		spriteClamp.limitMovement (transform.position, transform);
		Vector3 newPosition = transform.position;

		// check and see if the robot was just clamped in position 
		// (meaning, did limitMovement() function change the position vector?)
		//
		// if the new "Y" position is less than the original, that means
		// the player bumped up against the top of the screen.  We want
		// to zero out any remaining Y velocity at that point so he doesn't
		// appear to "stick" to the top of the screen while the remaining
		// upwards velocity dies out naturally.
		if (newPosition.y < oldPosition.y) 
		{
			rb.velocity = new Vector2 (0, 0);
		}
	}

    // this function will run for any physics-based collision
	void OnCollisionEnter2D(Collision2D otherObject)
	{
		// if we have hit the hidden pletform
		if (otherObject.gameObject.name.Equals ("HiddenPlatform")) 
		{
			// reset the available number of jumps each time
			// the player touches the platform
			numJumps = 3;

            //Change to run
            robotAnim.SetInteger("state", 0);
		}
	}

	// this function will run for any trigger-based collision
	void OnTriggerEnter2D(Collider2D otherObject)
	{
		// if we have hit a powerup charge
		if (otherObject.gameObject.CompareTag ("charge")) 
		{
			// increase number of shots and destroy the charge
			numShots++;
			updateShotsText ();
			Destroy (otherObject.gameObject);
		} 
		// else if we have hit a monster
		else if (otherObject.gameObject.CompareTag ("monster")) 
		{
			// call GameOver() on the controller script
			controller.GameOver ();

            //Change to dead state
            robotAnim.SetInteger("state", 2);
		}
	}

	// this function will update the display text for
	// # of remaining shots
	void updateShotsText()
	{
		shotsText.text = "Shots: " + numShots;
	}

	// create a new laser shot
	void fireShot()
	{
		// Instantiate object at current player location
		GameObject laser = (GameObject)Instantiate (laserPrefab, transform.position, Quaternion.identity);

		// give object a constant velocity in the X direction
		Rigidbody2D rb = laser.GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (laserSpeed, 0);

		// reduce # of available shots and update display text
		numShots--;
		updateShotsText ();
	}
}
