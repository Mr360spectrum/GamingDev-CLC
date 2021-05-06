using UnityEngine;
using System.Collections;

public class CarBehaviour : MonoBehaviour 
{
	// use Teleporter to wrap around screen
	private Teleporter porter;

	// will be calculated with some random value
	private float speed;

	// Use this for initialization
	void Start () 
	{
		// create new Teleporter object
		porter = new Teleporter (Camera.main);

		// Random.value gives random decimal number
		// between 0.0 and 1.0.  So the math below will
		// calculate random speed between 0.05 and 0.15.
		speed = (Random.value / 10.0f) + 0.05f;

	}
	
	// Update is called once per frame
	void Update () 
	{
		// move to the left at a steady pace
		transform.Translate (-speed, 0, 0);

		// wrap around the screen when the edge is reached
		porter.Wrap (gameObject);
	}
}
