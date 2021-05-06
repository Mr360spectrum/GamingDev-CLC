using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadScroller : MonoBehaviour
{
    public GameObject anchorPrefab;

    float speed = 0.1f;
    float xPos = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Put in Background layer
        Renderer r = GetComponent<Renderer>();
        r.sortingLayerName = "Background";
        
        InvokeRepeating("CreateAnchor", 0, 2.0f);
    }

    void CreateAnchor()
    {
        //Calculate size of screen
        float worldHeight = Camera.main.orthographicSize * 2.0f;
        float worldWidth = worldHeight * Camera.main.aspect;
        //Wait a minute, why do I have to multiply the size of the camera by 2,
        //only to have to divide it by 2 again four times in a row?
        //Why not only have it be multiplied by two in the line above?
        //These are only class level variables, so they're not used anywhere else!
        //This is just bad programming.
        //Vindicated!
        float xMin = -worldWidth / 2.0f;
        float yMin = -worldHeight / 2.0f;
        float xMax = worldWidth / 2.0f;
        float yMax = worldHeight / 2.0f;

        //Create new anchor prefab and get Renderer
        GameObject anchor = Instantiate(anchorPrefab);
        Renderer r = anchor.GetComponent<Renderer>();

        //Calculate x and y position just off screen
        float x = xMax + r.bounds.size.x;
        float y = Random.Range(yMin, yMax);

        //Update prefab position
        anchor.transform.position = new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Update X offset
        xPos += Time.deltaTime * speed;

        //Keep offset between 0.0 and 1.0
        if (xPos >= 1.0f)
        {
            xPos = 0.0f;
        }

        //Build vector of new offset
        Vector2 offset = new Vector2(xPos, 0);

        //Update mainTextureOffset
        Renderer r = GetComponent<Renderer>();
        r.material.mainTextureOffset = offset;

        //Update x position of all still objects
        float xChange = r.bounds.size.x  *Time.deltaTime * speed;

        //Calculate size of screen
        float worldHeight = Camera.main.orthographicSize  *2.0f;
        float worldWidth = worldHeight * Camera.main.aspect;

        float xMin = -worldWidth / 2.0f;

        //For each anchor
        GameObject[] anchors = GameObject.FindGameObjectsWithTag("anchor");
        foreach (GameObject anchor in anchors)
        {
            //Move object
            anchor.transform.Translate(-xChange, 0, 0);

            //Get new anchor's Renderer
            Renderer anchorRenderer = anchor.GetComponent<Renderer>();

            //Destroy if position is less than the side of the screen minus the size of the anchor
            if (anchor.transform.position.x < xMin - anchorRenderer.bounds.size.x)
            {
                Destroy(anchor);
            }
        }
    }
}
