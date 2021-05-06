/* Unity Game Programming
 * Treasure Hunt Project
 * Treasure Hunt Author
 * Project Date
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShipBehaviour : MonoBehaviour 
{
	// how fast does ship move?
	float speed = 0.1f;

	// world boundaries
	float WORLD_MIN_X = -10.0f;
	float WORLD_MIN_Y = -10.0f;
	float WORLD_MAX_X =  10.0f;
	float WORLD_MAX_Y =  10.0f;

	// Utility objects to limit the positions
	PositionClamp spriteClamp;
	PositionClamp cameraClamp;

	// Use this for initialization
	void Start () 
	{
        Renderer r = GetComponent<Renderer>();
		// set up PositionClamp to limit sprite position within world boundaries
		spriteClamp = new PositionClamp(WORLD_MIN_X, WORLD_MIN_Y, WORLD_MAX_X, WORLD_MAX_Y, r);

		// set up PositionClamp to limit camera position within world boundaries
        cameraClamp = new PositionClamp(WORLD_MIN_X, WORLD_MIN_Y, WORLD_MAX_X, WORLD_MAX_Y, Camera.main);
	}

	// Update is called once per frame
	void Update () 
	{
		// move the ship in the current direciton at the current speed
		transform.Translate(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);

		// Now that the position has been updated, limit
		// the X and Y coordinates and make sure they
		// do not go beyond certain boundaries
        spriteClamp.limitMovement(transform.position, transform);
        cameraClamp.limitMovement(transform.position, Camera.main.transform);

		// update new camera position (X and Y changes only)
		// to match new sprite position
        

	}

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		// if ship collided with island
		if (otherObject.CompareTag ("island")) 
		{
			// ship touched island, destroy island
			Destroy (otherObject.gameObject);
		} 
		// if ShipBehaviour collided with cannonball
		else if (otherObject.CompareTag ("cannonball")) 
		{
			// hit by cannon ball, game over
			Destroy(this.gameObject);
		}
	}

}
