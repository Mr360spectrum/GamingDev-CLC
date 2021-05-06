using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour 
{
	float scrollSpeed = 0.1f;
	float backgroundWidth;

	// references to GameObjects we'll use later
	GameObject background;
	GameObject shark;

	// Use this for initialization
	void Start () 
	{
		// get the width of the background sprite
		background = GameObject.Find ("background1");
		Renderer r = background.GetComponent<Renderer> ();
		backgroundWidth = r.bounds.size.x;
	}
	
	// Update is called once per frame
	void Update () 
	{
		// adjust the camera X-position
		Vector3 cameraPos = Camera.main.transform.position;
		cameraPos.x += scrollSpeed;

		// if the camera is located after the first image
		if (cameraPos.x > backgroundWidth) 
		{
			// reset the camera X back to 0
			cameraPos.x = 0;
		}

		// update the camera
		Camera.main.transform.position = cameraPos;

		// update the shark position to match the camera position
		GameObject shark = GameObject.Find("shark");
		cameraPos.z = 0;
		shark.transform.position = cameraPos;
	}
}
