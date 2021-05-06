/* Unity Game Programming
 * Treasure Hunt Project
 * Treasure Hunt Author
 * Project Date
 */

using UnityEngine;
using System.Collections;

public class CannonballScript : MonoBehaviour 
{
	// how many seconds to cannonballs last?
	float LIFESPAN = 5.0f;

	// Use this for initialization
	void Start () 
	{
		// when cannonball is created, schedule
		// a self-destruct function after # of seconds
		Invoke ("selfDestruct", LIFESPAN);
	}
	
	void selfDestruct() 
	{
		// this cannonball should now be destroyed
		Destroy (this.gameObject);
	}
}
