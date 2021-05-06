/* Unity Game Programming
 * Treasure Hunt Project
 * Treasure Hunt Author
 * Project Date
 */

using UnityEngine;
using System.Collections;

public class PirateBehaviour : MonoBehaviour 
{
	// how often do ships fire cannonballs?
	float SECONDS_PER_SHOT = 5.0f;

	// how fast to cannonballs move?
	float ballSpeed = 3.0f;

	// public varaible holding cannonball prefab
	public GameObject cannonballPrefab;

	// Use this for initialization
	void Start () 
	{
		// randomize start delay for first cannon shot
		float startDelay = Random.value * SECONDS_PER_SHOT;	

		// repeatedly fire cannonballs every few seconds after initial delay
		InvokeRepeating ("fireShot", startDelay, SECONDS_PER_SHOT);
	}

	// fire shot directly at current ship's location
	void fireShot()
	{
		// get reference to ship
		GameObject ship = GameObject.Find ("ship");
		if (!ship) 
		{
			// ship has been destroyed; game over
			return;
		}

		// calculate direction from pirate ship to player ship
		Vector3 direction = ship.transform.position - transform.position;

		// make this vector a unit vector with length 1
		direction.Normalize (); 

		// Instantiate new cannonball at current pirate ship location
		GameObject newBall = (GameObject)Instantiate (cannonballPrefab, transform.position, Quaternion.identity);

		// get the cannonball's Rigidbody2D and set the velocity based on direction and speed
		Rigidbody2D rb = newBall.GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (direction.x, direction.y) * ballSpeed;

	}
}
