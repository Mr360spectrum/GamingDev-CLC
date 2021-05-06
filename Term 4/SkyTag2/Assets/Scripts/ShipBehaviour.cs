using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShipBehaviour : MonoBehaviour 
{
	float speed = 0.1f;
	float steering = 5.0f;

	public Text output;

	public GameObject targetPrefab;

	// keep track of the target object we create
	GameObject targetObject;

	// world boundaries
	float WORLD_MIN_X = -10.0f;
	float WORLD_MIN_Y = -10.0f;
	float WORLD_MAX_X =  10.0f;
	float WORLD_MAX_Y =  10.0f;

	// Utility objects to limit the positions
	PositionClamp spriteClamp;

    PositionClamp cameraClamp;

	// Use this for initialization
	void Start () 
	{
		// set up PositionClamp to limit sprite position within world boundaries
		Renderer r = GetComponent<Renderer>();
		spriteClamp = new PositionClamp(WORLD_MIN_X,WORLD_MIN_Y,WORLD_MAX_X,WORLD_MAX_Y,r);

		// set up PositionClamp to limit camera position within world boundaries
        cameraClamp = new PositionClamp(WORLD_MIN_X, WORLD_MIN_Y, WORLD_MAX_X, WORLD_MAX_Y, Camera.main);

		// create the initial target and locate it somewhere in world boundaries
		targetObject = Instantiate(targetPrefab);
		moveTarget();
	}

	// Update is called once per frame
	void Update () 
	{
		// move the ship in the current direction at the current speed
		transform.Translate(speed, 0, 0);

		// Get steering left/right input.  
		// Adjust by steering scale factor to turn faster or slower
		float rotation = Input.GetAxis("Horizontal") * steering;

		// rotate ship left or right according to current input
		// (rotation will be 0 if no input)
		transform.Rotate(0, 0, -rotation);

		// Now that the position has been updated, limit
		// the X and Y coordinates and make sure they
		// do not go beyond certain boundaries
		spriteClamp.limitMovement(transform.position, transform);

        cameraClamp.limitMovement(transform.position, Camera.main.transform);

		// build new camera position (X and Y changes only)
		// Vector3 cameraPos = Camera.main.transform.position;
		// cameraPos.x = transform.position.x;
		// cameraPos.y = transform.position.y;

		// update camera position
		// Camera.main.transform.position = cameraPos;

		// display current ship position
		output.text = "X = " + transform.position.x.ToString("F1") + 
			        ", Y = " + transform.position.y.ToString("F1");

	}

	// relocate the target object to a new random position
	void moveTarget()
	{
		// get random coordinates within world boundaries
		float x = Random.Range (WORLD_MIN_X, WORLD_MAX_X);
		float y = Random.Range (WORLD_MIN_Y, WORLD_MAX_Y);

		// update target object coordinates
		targetObject.transform.position = new Vector3(x,y,0);
	}

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		// ship tagged the target, so move it
		moveTarget ();		
	}


}
