using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadScroller2 : MonoBehaviour
{
    public float speed;
    private float xPos;

    // Use this for initialization
    void Start () 
    {
        //Put into Foreground layer
        Renderer r = GetComponent<Renderer>();
        r.sortingLayerName = "Foreground";
    }

    // Update is called once per frame
    void Update () 
    {
        // update the x offset
        xPos += Time.deltaTime * speed;

        // keep offset in the 0.0 to 1.0 range
        if (xPos >= 1.0f) 
        {
            xPos = 0.0f;
        }

        // build vector of new offset
        Vector2 offset = new Vector2 (xPos, 0);

        // update the mainTextureOffset
        Renderer r = GetComponent<Renderer> ();
        r.material.mainTextureOffset = offset;
    }
}
