/* Unity Game Programming
 * Treasure Hunt Project
 * Treasure Hunt Author
 * Project Date
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControllerScript : MonoBehaviour 
{
	// public variables for prefab access
	public GameObject islandPrefab;
	public GameObject piratePrefab;

	public GameObject emptyOceanTilePrefab;
	public GameObject[] ocenTilePrefabs;

	// public variable for message text
	public Text gameOverText;

	// world boundaries
	float WORLD_MIN_X = -10.0f;
	float WORLD_MIN_Y = -10.0f;
	float WORLD_MAX_X =  10.0f;
	float WORLD_MAX_Y =  10.0f;

	// game parameters - adjust to make 
	// easier or more difficult
	int NUM_ISLANDS = 10;
	int NUM_PIRATES = 10;

	// Use this for initialization
	void Start ()
	{
		// clear message text
		gameOverText.text = "";

		// create tiles, islands, and pirates
		createTiles ();
		createIslands ();
		createPirates ();
	}

	// This function is responsible for creating a grid of 
	// tiles that covers the entire virtual world.
	void createTiles()
	{
		if (emptyOceanTilePrefab == null) 
		{
			return; // tile prefabs not set up yet
		}

		// get width and height of tile in world coordinates
		Renderer r = emptyOceanTilePrefab.GetComponent<Renderer>();
		float tileWidth = r.bounds.size.x;
		float tileHeight = r.bounds.size.y;

		// calculate starting X position of the leftmost tile
		float newTileX = WORLD_MIN_X + tileWidth / 2.0f;

		// while our tile X position is still within our boundaries
		while (newTileX < WORLD_MAX_X) 
		{
			// calculate starting Y position of the bottom-most tile 
			// in this column
            float newTileY = WORLD_MIN_Y + tileHeight / 2.0f;

			// while our tile Y position is still within our boundaries
            while (newTileY < WORLD_MAX_Y)
			{
				// default tile is empty sky
				GameObject prefab = emptyOceanTilePrefab;

				// get a random number between 0.0 and 1.0
				float rand = Random.value;
				if (rand < 0.02) // 2% of the time
				{
					// select random tile from our prefab array
					int index = Random.Range(0,ocenTilePrefabs.Length);
					prefab = ocenTilePrefabs [index];
				} 

				// instantiate new tile at this position
                Instantiate(prefab, new Vector3(newTileX, newTileY, 0), Quaternion.identity);

				// move up one row to the next tile above
                newTileY += tileHeight;

			} /* end of inner while() loop */

			// move one column to the right
			newTileX += tileWidth;

		} /* end of outer while() loop */

	}

	// This function creates the islands in random locations
	void createIslands ()
	{
		// for each island
		for (int i = 0; i < NUM_ISLANDS; i++) 
		{
			// Calculate random X and Y within the world. 
			// Add and subtract 1 from the boundaries so no
			// sprite is created directly on an edge.
			float x = Random.Range (WORLD_MIN_X + 1, WORLD_MAX_X - 1);
			float y = Random.Range (WORLD_MIN_Y + 1, WORLD_MAX_Y - 1);

			// create island from prefab
			Instantiate (islandPrefab, new Vector3(x,y,0), Quaternion.identity);
		}
	}

	// This function creates the pirates in random locations
	void createPirates ()
	{
		// for each pirate
		for (int i = 0; i < NUM_PIRATES; i++) 
		{
			// Calculate random X and Y within the world. 
			// Add and subtract 1 from the boundaries so no
			// sprite is created directly on an edge.
			float x = Random.Range (WORLD_MIN_X + 1, WORLD_MAX_X - 1);
			float y = Random.Range (WORLD_MIN_Y + 1, WORLD_MAX_Y - 1);

			// create pirate from prefab
			Instantiate (piratePrefab, new Vector3(x,y,0), Quaternion.identity);
		}
	}

	// Update is called once per frame
	void Update () 
	{
		// check game-over conditions and modify message text
		// if the game is over.

		// if there are no islands left
		if (GameObject.FindGameObjectWithTag ("island") == null) 
		{
			gameOverText.text = "All island treasures collected!";
			Destroy(GameObject.Find ("ship"));	// remove ship from game
		} 
		else if (GameObject.Find("ship") == null)
		{
			// the ship has been destroyed by a cannonball
			gameOverText.text = "Ouch!  Better luck next time.";
		}
	}

	// OnGUI is called once per frame after other rendering is done
	void OnGUI()
	{
		// create a mini-map showing the ship, pirates, and islands

		// overall world dimensions, in world units
		float worldWidth = (WORLD_MAX_X - WORLD_MIN_X);
		float worldHeight = (WORLD_MAX_Y - WORLD_MIN_Y);

		// ratio of world height to width
		float worldAspectRatio = worldHeight / worldWidth;

		// calculate size of mini-map in pixels
		float mapWidth = Screen.width * 0.2f;	// 20% of width
		float mapHeight = mapWidth * worldAspectRatio;

		// build Vector2s holding map size and starting pixel coordinates
		Vector2 mapSize = new Vector2 (mapWidth, mapHeight);
		Vector2 mapStart = new Vector2 (Screen.width - mapSize.x - 10, Screen.height - mapSize.y - 10);

		// build and draw Rect holding map screen boundaries
        Rect mapBorder = new Rect(mapStart, mapSize);
        DrawShapes.DrawRectangle(mapBorder, Color.black, 2);

		// calculate center of mini-map in screen coordinates
		Vector2 mapCenter = new Vector2 (mapStart.x + mapSize.x / 2, mapStart.y + mapSize.y / 2);

		// calculate ratio of map pixels per world unit in each direction
		float mapScaleX = mapWidth / worldWidth;	 
		float mapScaleY = -mapHeight /  worldHeight;

		// find the ship object we want to show on the map
		GameObject shipObj = GameObject.Find ("ship");

		// if ship is alive
		if (shipObj != null) 
		{	
			// convert ship's world coordinates to 
			// mini-map pixel coordinates
            float shipMapX = shipObj.transform.position.x * mapScaleX + mapCenter.x;
            float shipMapY = shipObj.transform.position.y * mapScaleY + mapCenter.y;

			// build a Rect to represent the ship on the map
            Rect shipMapRect = new Rect(shipMapX - 3, shipMapY - 3, 5, 5);

			// draw ship as a small red rectangle
            DrawShapes.DrawRectangle(shipMapRect, Color.red, 2);
		}

		// find all of the islands
		GameObject[] islands = GameObject.FindGameObjectsWithTag("island");
		foreach (GameObject island in islands) 
		{
			// convert islands's world coordinates to 
			// mini-map pixel coordinates
            float islandMapX = island.transform.position.x * mapScaleX + mapCenter.x;
            float islandMapY = island.transform.position.y * mapScaleY + mapCenter.y;

			// draw target as a small white circle
            Vector2 islandMapPos = new Vector2(islandMapX, islandMapY);
            DrawShapes.DrawCircle(islandMapPos, 3, Color.white, 3);
		}

	}
}
