/* PositionClamp Object
 * Unity Game Programming
 * CompuScholar, Inc.
 * 
 * This object limits the position of a sprite or camera
 * to fall within defined world boundaries.
 */

using UnityEngine;
using System.Collections;

public class PositionClamp
{
	// calculated position boundaries in world coordinates
	float minX;
	float minY;

	float maxX;
	float maxY;

	// constructor used to clamp a sprite
	public PositionClamp(float worldMinX, float worldMinY, float worldMaxX, float worldMaxY, Renderer r)
	{
		// calculate half sprite width and height from renderer
		float halfSpriteWidth = r.bounds.size.x / 2.0f;
		float halfSpriteHeight = r.bounds.size.y / 2.0f;

		// calculate and save boundaries
		minX = worldMinX + halfSpriteWidth;
		minY = worldMinY + halfSpriteHeight;

		maxX = worldMaxX - halfSpriteWidth;
		maxY = worldMaxY - halfSpriteHeight;
	}

	// constructor used to clamp a camera
	public PositionClamp(float worldMinX, float worldMinY, float worldMaxX, float worldMaxY, Camera cam)
	{
		// calculate half camera width and height, in world dimensions
		float halfCameraHeight = cam.orthographicSize;    
		float halfCameraWidth = halfCameraHeight * cam.aspect;

		// calculate and save boundaries
		minX = worldMinX + halfCameraWidth;
		minY = worldMinY + halfCameraHeight;

		maxX = worldMaxX - halfCameraWidth;
		maxY = worldMaxY - halfCameraHeight;
	}

	// limit the input position to the defined world boundaries
	// and update the provided Transform with the results
	public void limitMovement(Vector3 targetPosition, Transform trans)
	{
		// Clamp the X and Y coordinates and make sure they
		// do not go beyond calculated boundaries
		float clampedX = Mathf.Clamp(targetPosition.x,minX,maxX);
		float clampedY = Mathf.Clamp(targetPosition.y,minY,maxY);

		// update transform position
		trans.position = new Vector3 (clampedX, clampedY, trans.position.z);
	}

}
