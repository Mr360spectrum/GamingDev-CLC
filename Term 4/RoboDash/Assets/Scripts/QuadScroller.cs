/* Unity Game Programming
 * RoboDash Project
 * RoboDash Author
 * Project Date
 */

using UnityEngine;
using System.Collections;

public class QuadScroller : MonoBehaviour 
{
	// public variables to control background
	// scroll speed and sorting layer
	public float speed = 0.02f;
	public string sortingLayer = "Background";

	// internal variable to track current offset
	float xPos = 0;

	// reference to the main controller script
	ControllerScript controller;

	// one-time startup
	void Start()
	{
		// put this quad in the target sorting layer
		Renderer r = GetComponent<Renderer> ();
		r.sortingLayerName = sortingLayer;

		// get and store reference to ControllerScript for future use
		GameObject controllerObj = GameObject.Find ("Controller");
		controller = controllerObj.GetComponent<ControllerScript> ();
	}

	// Update is called once per frame
	void Update () 
	{
		// check and see if the game is over
		if (controller.IsGameOver ()) 
		{
			return; // if so, don't do anything
		}

		// update the x offset
		xPos += Time.deltaTime * speed;

		// keep offset in the 0.0 to 1.0 range
		if (xPos >= 1.0f) 
		{
			xPos = 0.0f;
		}

		// build vector of new offset
		Vector2 offset = new Vector2 (xPos, 0);

		// update the mainTextureOffset
		Renderer r = GetComponent<Renderer> ();
		r.material.mainTextureOffset = offset;
	}
}
