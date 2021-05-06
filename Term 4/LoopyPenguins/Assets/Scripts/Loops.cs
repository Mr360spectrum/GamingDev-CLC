using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Loops : MonoBehaviour 
{
	// reference to penguin prefab object
	public GameObject penguinPrefab;

	// location where penguins start on the left
	public float xStart = -4.0f;

	// amount of space to place between penguins
	public float xOffset = 2.0f;

	// number of penguins to create
	public int numPenguins = 5;

	// Use this for initialization
	void Start () 
	{
		// for(int i=0; i<numPenguins; i++)
        // {
        //     float xLocation = xStart + (i * xOffset);
        //     Instantiate(penguinPrefab, new Vector3(xLocation, 0, 0), Quaternion.identity);
        // }

        int i = 0;
        while(i < numPenguins)
        {
            float xLocation = xStart + (i * xOffset);
            Instantiate(penguinPrefab, new Vector3(xLocation, 0, 0), Quaternion.identity);
            i++;
        }

	}

	// Update is called once per frame
	void Update () 
	{
		// if the space bar was just pressed
		if (Input.GetKeyDown ("space")) 
		{
			// get all of game objects with the "penguin" tag
			// GameObject[] penguins = GameObject.FindGameObjectsWithTag ("penguin");
            // foreach(GameObject penguin in penguins)
            // {
            //     Destroy(penguin);
            // }

            GameObject penguin = null;
            do
            {
                penguin = GameObject.FindWithTag("penguin");
                if (penguin != null)
                {
                    penguin.SetActive(false);
                }
            }
            while(penguin != null);
		}
		
	}
}
