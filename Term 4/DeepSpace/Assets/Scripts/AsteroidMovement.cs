/* Unity Game Programming
 * Deep Space Project
 * Deep Space Author
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

    public Teleporter porter;

    ShipMovement shipScript;

	// Use this for initialization
	void Start () 
	{
		// calculate random direction for this asteroid
		// Random.value will return a random number between
		// 0.0 and 1.0.
		dx = (Random.value - 0.5F) / speedReduction;
		dy = (Random.value - 0.5F) / speedReduction;

        porter = new Teleporter(Camera.main);

        GameObject shipObject = GameObject.Find("spaceship");
        shipScript = shipObject.GetComponent<ShipMovement>();
	}
	
	// Update is called once per frame
	void Update () 
	{
        // if the game is not over
		if (!shipScript.GameOver) // replace with GameOver
		{
			// move 
			transform.Translate (dx, dy, 0);
            porter.Wrap(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		// if this asteroid has hit one of the source wormholes...
		if (otherObject.gameObject.name.Equals ("wormholeSource1")) 
		{
            GameObject targetObject = GameObject.Find("wormholeTarget1");
            porter.Teleport(gameObject, targetObject);
		} 
		else if (otherObject.gameObject.name.Equals ("wormholeSource2")) 
		{
            GameObject targetObject = GameObject.Find("wormholeTarget2");
            porter.Teleport(gameObject, targetObject);
		}
		else if (otherObject.gameObject.name.Equals ("wormholeSource3")) 
		{
		    GameObject targetObject = GameObject.Find("wormholeTarget3");
            porter.Teleport(gameObject, targetObject);
		}
	}
}
