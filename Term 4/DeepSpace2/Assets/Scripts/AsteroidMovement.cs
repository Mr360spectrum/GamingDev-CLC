/* Unity Game Programming
 * Deep Space 2 Project
 * Deep Space 2 Author
 * Project Date
 */

using UnityEngine;
using System.Collections;

public class AsteroidMovement : MonoBehaviour 
{
	// this asteroid's direction components
	private float dx;
	private float dy;

	// adjust this up to slow down the asteroids
	private float speedReduction = 10.0F;

	// this asteroid will use this Teleporter object
	Teleporter porter;

	// Use this for initialization
	void Start () 
	{
		// calculate random direction for this asteroid
		// Random.value will return a random number between
		// 0.0 and 1.0.
		dx = (Random.value - 0.5F) / speedReduction;
		dy = (Random.value - 0.5F) / speedReduction;

		// create a new Teleporter object
		porter = new Teleporter (Camera.main);

		// get a reference to the spaceship GameObject
		GameObject shipObject = GameObject.Find ("spaceship");

	}
	
	// Update is called once per frame
	void Update () 
	{
		// move 
		transform.Translate (dx, dy, 0);

		// wrap position to other side of screen if needed
		porter.Wrap (gameObject);
	}

}
