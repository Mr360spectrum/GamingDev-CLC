/* Unity Game Programming
 * Banana Breakout
 * Author name
 * Project date
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour 
{
	// public variables lets the user easily
	// control the number of blocks and rows
	public int blocksPerRow = 8;
	public int numRows = 3;

	// public variable for text widget
	public Text gameOverText;

	// public array holding references to the prefab blocks
	public GameObject[] blockPrefabs;

	// index into blockPrefabs array
	private int currentPrefab = 0;

	// calculated values to display the chosen
	// number of rows and columns across the screen
	private float startingX;
	private float startingY;
	private float xOffset;
	private float yOffset;

	// Use this for initialization
	void Start () 
	{
		// reset current prefab index and game over text
		currentPrefab = 0;
		gameOverText.text = "";

		// create the first set of blocks
		createBlocks ();
	}

	void Update()
	{
	}

	// This public function can be called by other scripts
	// (MonkeyScript) to see if all the blocks are gone and,
	// if so, regenerate the next set of blocks.
	public bool CheckRestart()
	{
        // if there are not any blocks left
		if (!anyBlocksLeft())
		{
			// create new blocks
			createBlocks ();
			return true; // signal restart
		}
		return false; // signal no restart
	}

	// This function will create a new set of blocks
	// using the current prefab index.  It will also
	// increment the prefab index to the next spot in
	// the prefab array.
	void createBlocks()
	{
		// safety check in case the prefab array is not initialized
		if (blockPrefabs.Length == 0) 
		{
			return;	// no blocks to create
		}

		// get the current prefab object
		GameObject prefab = blockPrefabs[currentPrefab];

		// scale it to fill the screen based on current
		// number of rows and columns
		scalePrefab (prefab);

		for (int row = 0; row < numRows - 1; row++)
        {
            for (int col = 0; col < blocksPerRow - 1; col++)
            {
                float xLocation = startingX + (col * xOffset);
                float yLocation = startingY - (row * yOffset);

                Instantiate(prefab, new Vector3(xLocation, yLocation, 0), Quaternion.identity);
            }
        }
        currentPrefab++;
        if (currentPrefab >= blockPrefabs.Length)
        {
            currentPrefab = 0;
        }

	}

	// Edge Trigger Collider at bottom of screen
	void OnTriggerEnter2D(Collider2D otherObject)
	{
		// if the monkey has hit the invisible edge at the bottom of the screen
		if (otherObject.gameObject.name == "Monkey")
		{
			// update game over text
			gameOverText.text = "Game Over!";

			// delete the Monkey and the trampoline
			Destroy(otherObject.gameObject);

			GameObject trampoline = GameObject.Find ("Trampoline");
			Destroy (trampoline);
		}
	}

	// this utility function will return true if any objects
	// with the "block" tag are left on the screen
	bool anyBlocksLeft()
	{
        GameObject isBlock = GameObject.FindWithTag("block");
        if (isBlock != null)
        {
            return true;
        }

		// no block found
		return false;
	}

	// This utility function will calculate the size, starting positions,
	// and offsets necessary to draw the current prefab block on the screen 
	// and cover the entire width from left to right.
	void scalePrefab (GameObject prefab)
	{
		// calculate the width of the screen
		float worldHeight = Camera.main.orthographicSize * 2.0F;
		float worldWidth = worldHeight * Camera.main.aspect;

		// calculate the width of one block so the # of blocks per row fills the screen
		float targetBlockWidth = worldWidth / blocksPerRow;

		// reset any previous scaling that was done to this prefab
		prefab.transform.localScale = new Vector3 (1.0F, 1.0F, 0);

		// find the normal (unscaled) width
		Renderer r = prefab.GetComponent<Renderer>();
		float originalBlockWidth = r.bounds.size.x;
		float originalBlockHeight = r.bounds.size.y;

		// calculate the scaling factor to reach desired width
		float scaleFactor = targetBlockWidth / originalBlockWidth;

		// update the X and Y scaling factor to the same new value
		prefab.transform.localScale = new Vector3 (scaleFactor, scaleFactor, 0);

		// calculate the xOffset and yOffset needed to neatly stack blocks
		// of the new size across the screen
		xOffset = targetBlockWidth;
		yOffset = originalBlockHeight * scaleFactor;

		// calculate upper-left starting location for first block
		startingX = (-worldWidth / 2.0F) + (xOffset / 2.0F);
		startingY = (worldHeight / 2.0F) - (yOffset / 2.0F);
	}
}
