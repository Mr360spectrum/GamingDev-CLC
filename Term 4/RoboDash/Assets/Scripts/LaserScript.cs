/* Unity Game Programming
 * RoboDash Project
 * RoboDash Author
 * Project Date
 */

using UnityEngine;
using System.Collections;

public class LaserScript : MonoBehaviour 
{
	Vector2 upperRightWorld;
	Renderer r;

	void Start()
	{
		// record screen boundary coordinates for later use
		float worldHeight = Camera.main.orthographicSize * 2.0F;
		float worldWidth = worldHeight * Camera.main.aspect;

		upperRightWorld = new Vector2 (worldWidth / 2.0F, worldHeight / 2.0F);

		// Get the object's Renderer component for later use
		r = GetComponent<Renderer>();
	}

	// Update is called once per frame
	void Update ()
	{
		// if object X position is greater than the right boundary coordinate
		// plus the width of the object (to ensure it's fully off the screen)
		if (transform.position.x > upperRightWorld.x + r.bounds.size.x) 
		{
			Destroy (gameObject);  // destroy this object
		}
	}

	// lasers just need to know if they have hit something else
	void OnTriggerEnter2D(Collider2D otherObject)
	{
		// if we hit a monster object
		if (otherObject.gameObject.CompareTag ("monster")) 
		{
			// destroy both monster and laster objects
			Destroy (otherObject.gameObject);
			Destroy (this.gameObject);

			// call the IncreaseScore() function on the 
			// controller script
			GameObject controller = GameObject.Find ("Controller");
			ControllerScript cs = controller.GetComponent<ControllerScript> ();
			cs.IncreaseScore ();
		}
	}
}
