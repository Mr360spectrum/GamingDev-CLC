using UnityEngine;
using System.Collections;

public class GuppyScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		// move the guppy according to the inputs
		transform.Translate (Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"), 0.0f);
	}
}
