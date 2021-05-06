/* Teleporter Object
 * Unity Game Programming
 * CompuScholar, Inc.
 * 
 * This object provides a variety of useful movement
 * features like wrapping an object around to the other
 * side of the screen or moving it to match another
 * object's position.
 */

using UnityEngine;
using System.Collections;

public class Teleporter
{
	// reference to the scene's Camera
	private Camera mainCamera;

	// calculated world coordinates of the
	// edges of the scene
	private float xMin;
	private float yMin;
	private float xMax;
	private float yMax;

	// constructor function requires a Camera
	public Teleporter(Camera cam) 
	{
		// save the camera reference for later use
		mainCamera = cam;

		// calculate the minimum and maximum X and Y positions on the screen
		// and store for future use
		float worldHeight = mainCamera.orthographicSize * 2.0F;
		float worldWidth = worldHeight * mainCamera.aspect;

		xMin = -worldWidth/2.0F;
		yMin = -worldHeight/2.0F;
		xMax = worldWidth/2.0F;
		yMax = worldHeight/2.0F;
	}

	// this function will teleport an object to the opposite side of the screen
	// if it has moved off the edge in any direction
	public void Wrap(GameObject obj) 
	{
		// we will look at the object's width and height to make 
		// the wrapping more realistic.
		float objHalfWidth = 0.0F;
		float objHalfHeight = 0.0F;

		// get a reference to the object's Renderer component
		Renderer r = obj.GetComponent<Renderer> ();
		if (r != null) 
		{
			// calculate half of the width and height
			objHalfWidth = r.bounds.size.x / 2.0F;
			objHalfHeight = r.bounds.size.y / 2.0F;
		}

		// if the object is all the way off the screen to the left
		if (obj.transform.position.x < (xMin - objHalfWidth)) 
		{
			// wrap around to the right
			obj.transform.position = new Vector3 (xMax + objHalfWidth, obj.transform.position.y, 0);
		}
		// if the object is all the way off the screen to the right
		else if (obj.transform.position.x > (xMax + objHalfWidth))
		{
			// wrap around to the left
			obj.transform.position = new Vector3 (xMin - objHalfWidth, obj.transform.position.y, 0);
		}


		// if the object is all the way off the screen to the bottom
		if (obj.transform.position.y < (yMin - objHalfHeight)) 
		{
			// wrap around to the top
			obj.transform.position = new Vector3 (obj.transform.position.x, yMax + objHalfHeight, 0);
		}
		// if the object is all the way off the screen to the top
		else if (obj.transform.position.y > (yMax + objHalfHeight)) 
		{
			// wrap around to the bottom
			obj.transform.position = new Vector3 (obj.transform.position.x, yMin - objHalfHeight, 0);
		}

	}

	// this function will update the source object's position
	// to match the target object's position
	public void Teleport(GameObject source, GameObject destination)
	{
		if ((source != null) && (destination != null))
		{
			source.transform.position = destination.transform.position;
		}
	}
}
