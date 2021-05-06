using UnityEngine;
using System.Collections;

public class ControllerScript : MonoBehaviour 
{
	public GameObject emptySkyTilePrefab;
	public GameObject[] skyTilePrefabs;

	// world boundaries
	float WORLD_MIN_X = -10.0f;
	float WORLD_MIN_Y = -10.0f;
	float WORLD_MAX_X =  10.0f;
	float WORLD_MAX_Y =  10.0f;

	// Use this for initialization
	void Start ()
	{
		// get width and height of tile in world coordinates
		Renderer r = emptySkyTilePrefab.GetComponent<Renderer>();
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
				GameObject prefab = emptySkyTilePrefab;

				// get a random number between 0.0 and 1.0
				float rand = Random.value;
				if (rand < 0.2) // 20% of the time
				{
					// select random tile from our prefab array
					int index = Random.Range(0,skyTilePrefabs.Length);
					prefab = skyTilePrefabs [index];
				} 

				// instantiate new tile at this position
				Instantiate (prefab, new Vector3(newTileX,newTileY,0), Quaternion.identity);

				// move up one row to the next tile above
				newTileY += tileHeight;

			} /* end of inner while() loop */

			// move one column to the right
			newTileX += tileWidth;

		} /* end of outer while() loop */

	}

	// Update is called once per frame
	void Update () 
	{
	
	}

	// OnGUI is called once per frame after other rendering is done
	void OnGUI()
	{
		// create a mini-map showing the ship and target

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
		Rect mapBorder = new Rect (mapStart, mapSize);
		DrawShapes.DrawRectangle (mapBorder, Color.black, 2);

		// calculate center of mini-map in screen coordinates
		Vector2 mapCenter = new Vector2 (mapStart.x + mapSize.x / 2, mapStart.y + mapSize.y / 2);

		// calculate ratio of map pixels per world unit in each direction
		float mapScaleX = mapWidth / worldWidth;	 
		float mapScaleY = -mapHeight /  worldHeight;

		// find the ship object we want to show on the map
		GameObject shipObj = GameObject.Find ("ship");

		// convert ship's world coordinates to mini-map pixel coordinates
		float shipMapX = shipObj.transform.position.x * mapScaleX + mapCenter.x;
		float shipMapY = shipObj.transform.position.y * mapScaleY + mapCenter.y;

		// build a Rect to represent the ship on the map
		Rect shipMapRect = new Rect (shipMapX - 3, shipMapY - 3, 5, 5);

        //Find target object
        GameObject targetObj = GameObject.FindWithTag("target");

        //Convert target's coordinates to mini-map coordinates
        float targetMapX = targetObj.transform.position.x * mapScaleX + mapCenter.x;
        float targetMapY = targetObj.transform.position.y * mapScaleY + mapCenter.y;

		// draw ship as a small red rectangle
		DrawShapes.DrawRectangle (shipMapRect, Color.red, 2);

		//Draw target as small black circle
        Vector2 targetMapPos = new Vector2(targetMapX, targetMapY);
        DrawShapes.DrawCircle(targetMapPos, 4, Color.black, 2);

	}
}
