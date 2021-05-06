using UnityEngine;
using System.Collections;

public class CatMovement : MonoBehaviour 
{
    //Manage Tracker
    Tracker myTracker;

	// adjust speed to make the cat move 
	// faster or slower
	public float speed = 0.04f;

	// Use this for initialization
	void Start () 
	{
        //Create Tracker object
        myTracker = new Tracker(gameObject, "mouse");
	}
	
	// Update is called once per frame
	void Update () 
	{
        //Get direction to travel
        Vector2 direction = myTracker.GetDirection();

        //Translate this object along direction of travel
        //using a scaling factor to control speed
        transform.Translate(direction.x * speed, direction.y * speed, 0);
	}
}
