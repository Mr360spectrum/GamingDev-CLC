/*
 * DrawShapes Utility Package
 * Original source taken and modified from:
 * http://wiki.unity3d.com/index.php?title=DrawLine
 * 
 */

//****************************************************************************************************
//  Usage:
//  DrawShapes.DrawLine(Vector2 pointA, Vector2 pointB, Color color, float width)
//  DrawShapes.DrawRectangle(Rect r, Color color, float width)
//  DrawShapes.DrawCircle(Vector2 center, float radius, Color color, float width)
//****************************************************************************************************

using System;
using UnityEngine;

public class DrawShapes
{
	public static Texture2D lineTex;

	// draw a single 2D line
	public static void DrawLine(Vector2 pointA, Vector2 pointB, Color color, float width)
	{
		// Save the current GUI matrix, since we're going to make changes to it.
		Matrix4x4 matrix = GUI.matrix;
		GUI.matrix = Matrix4x4.identity;

		// For some reason, everything is rotated around the wrong place until some kind of offset is used. The exact value of this was a bit of guesswork - your mileage may vary.
		Vector2 offset = new Vector2(0, 0);

		// Generate a single pixel texture if it doesn't exist
		if (!lineTex) { lineTex = new Texture2D(1, 1); }

		// Store current GUI color, so we can switch it back later,
		// and set the GUI color to the color parameter
		Color savedColor = GUI.color;
		GUI.color = color;

		// Set the GUI matrix to rotate around a pivot point
		Quaternion guiRot = Quaternion.FromToRotation(Vector2.right, pointB-pointA);
		Matrix4x4 guiRotMat = Matrix4x4.TRS(pointA, guiRot, new Vector3((pointB-pointA).magnitude, width, 1));
		Matrix4x4 guiTransMat = Matrix4x4.TRS(offset, Quaternion.identity, Vector3.one);
		Matrix4x4 guiTransMatInv = Matrix4x4.TRS(-offset, Quaternion.identity, Vector3.one);

		GUI.matrix = guiTransMatInv * guiRotMat * guiTransMat;

		// Finally, draw the actual line.
		// We're really only drawing a 1x1 texture from pointA.
		// The matrix operations done with Scale, Rotate and Translate will make this
		//  render with the proper width, length, and angle and position
		GUI.DrawTexture(new Rect(0, 0, 1, 1), lineTex);

		// We're done.  Restore the GUI matrix and GUI color to whatever they were before.
		GUI.matrix = matrix;
		GUI.color = savedColor;
	}

	// draw a single 2D rectangle
	public static void DrawRectangle(Rect r, Color color, float width)
	{
		// create 4 points from the input rectangle
		Vector2 upperLeft = new Vector2 (r.x, r.y);
		Vector2 upperRight = new Vector2 (r.x + r.width, r.y);
		Vector2 lowerRight = new Vector2 (r.x + r.width, r.y + r.height);
		Vector2 lowerLeft = new Vector2 (r.x, r.y + r.height);

		// draw the 4 line segments
		DrawLine (upperLeft, upperRight, color, width);
		DrawLine (upperRight, lowerRight, color, width);
		DrawLine (lowerRight, lowerLeft, color, width);
		DrawLine (lowerLeft, upperLeft, color, width);
	}

	// draw a single 2D circle 
	public static void DrawCircle(Vector2 center, float radius, Color color, float width)
	{
		// Calculate a rough number of points that will look good at multiple sizes.  
		// without going overboard on small circles.  Adjust as needed.
		int numPoints = 10 + (int)(radius / 3.0f);

		// starting and ending points for line segments
		Vector2 p1;
		Vector2 p2;

		// current angle
		float theta = 0f;

		// calculate initial starting point
		p1 = new Vector2 (center.x + radius * Mathf.Cos (theta), center.y + radius * Mathf.Sin (theta));

		// for each of the segmetns on the line
		for (int i = 0; i < numPoints; i++)
		{   
			// increase angle
			theta += (2 * Mathf.PI / numPoints);         

			// calculate second point
			p2.x = center.x + radius * Mathf.Cos(theta);
			p2.y = center.y + radius * Mathf.Sin(theta);          

			// draw line segment
			DrawLine (p1, p2, color, width);

			// save second point as new first point
			p1 = p2;
		}		
	}


}