/* Unity Game Programming
 * Mower Dodgeball Project
 * Mower Dodgeball Author
 * Project Date
 */

using UnityEngine;
using System.Collections;

public class BladeScript: MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		// get the RigigBody2D component on this blade
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();

		// Set the angular velocity of the blade to
		// spin it at a constant rate.  We do this
		// instead of transform.rotate() to ensure
		// the physics engine knows the blade is spinning
		// and will impact the balls accordingly.
		rb.angularVelocity = 500.0F;

		// Update the current position of the blade
		// to match the current mower position.
		// This will keep the blade from getting knocked
		// away from the mower by the impact of the 
		// balls or walls.
		transform.position = transform.parent.position;
	}
}
