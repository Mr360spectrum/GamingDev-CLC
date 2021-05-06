using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkScript : MonoBehaviour
{
    float speed = 0.2f;
    PositionClamp sharkClamp;

    // Start is called before the first frame update
    void Start()
    {
        //Calculate size of screen
        float worldHeight = Camera.main.orthographicSize * 2.0f;
        float worldWidth = worldHeight * Camera.main.aspect;

        float xMin = -worldWidth / 2.0f;
        float yMin = -worldHeight / 2.0f;
        float xMax = worldWidth / 2.0f;
        float yMax = worldHeight / 2.0f;

        //Get sprite renderer
        Renderer r = GetComponent<Renderer>();

        //Create PositionClamp on camera boundaries
        sharkClamp = new PositionClamp(xMin, yMin, xMax, yMax, r);    
    }

    // Update is called once per frame
    void Update()
    {
        //Allow shark movement in any direction
        transform.Translate(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);

        //Clamp shark position to camera boundaries
        sharkClamp.limitMovement(transform.position, transform);
    }
}
