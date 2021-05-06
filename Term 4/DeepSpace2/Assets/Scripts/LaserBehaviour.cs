/* Unity Game Programming
 * Deep Space 2 Project
 * Deep Space 2 Author
 * Project Date
 */

using UnityEngine;
using System.Collections;

public class LaserBehaviour : MonoBehaviour 
{
	// change this to adjust laser movement speed
	private float speed = 0.10F;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (speed, 0, 0);
	}

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		// if this laser collided with an asteroid
		if (otherObject.gameObject.CompareTag ("asteroid")) 
		{
			// get a reference to the space ship
			GameObject shipObj = GameObject.Find("spaceship");

			// get a reference to the script on the ship
			ShipBehaviour shipScript = shipObj.GetComponent<ShipBehaviour> ();

			// call IncreaseScore()
			shipScript.IncreaseScore ();

			// destroy the asteroid
			Destroy(otherObject.gameObject);
		}
	}
}
