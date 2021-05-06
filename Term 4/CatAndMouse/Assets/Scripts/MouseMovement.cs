using UnityEngine;
using System.Collections;

public class MouseMovement : MonoBehaviour 
{
	// adjust speed to make the mouse move 
	// faster or slower
	float speed = 0.05F;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		// move left/right and up/down.
		// scale input by speed factor 
		transform.Translate (Input.GetAxis ("Horizontal") * speed, 
			                 Input.GetAxis ("Vertical") * speed, 0);
	}
}
