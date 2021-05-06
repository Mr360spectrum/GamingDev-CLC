using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShipBehaviour : MonoBehaviour 
{
	float speed = 0.3f;

	public Text output;

    //World boundaries
    float WORLD_MIN_X = -10.0f;
    float WORLD_MIN_Y = -10.0f;
    float WORLD_MAX_X = 10.0f;
    float WORLD_MAX_Y = 10.0f;

    PositionClamp spriteClamp;

	// Use this for initialization
	void Start () 
	{
        //Initialize PositionClamp for this sprite
        Renderer r = GetComponent<Renderer>();
        spriteClamp = new PositionClamp(WORLD_MIN_X, WORLD_MIN_Y, WORLD_MAX_X, WORLD_MAX_Y, r);
	}
	
	// Update is called once per frame
	void Update () 
	{
		// move the ship
		transform.Translate (Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);

        //Limit movement
        spriteClamp.limitMovement(transform.position, transform);

		// build new camera position (X and Y changes only)
		Vector3 cameraPos = Camera.main.transform.position;
		cameraPos.x = transform.position.x;
		cameraPos.y = transform.position.y;

		// update camera position
		Camera.main.transform.position = cameraPos;

		// display current ship position
		output.text = "X = " + transform.position.x.ToString("F1") + 
			        ", Y = " + transform.position.y.ToString("F1");

	}
}
