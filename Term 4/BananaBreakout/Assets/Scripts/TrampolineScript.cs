/* Unity Game Programming
 * Banana Breakout
 * Author name
 * Project date
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineScript : MonoBehaviour 
{
	// Movement Speed
	public float speed = 0.2F;

	// Use this for initialization
	void Start () 
	{

	}

	void Update()
	{
		// allow the user to control the trampoline with left/right arrow keys
		transform.Translate(Input.GetAxis("Horizontal") * speed, 0, 0);
	}
}
