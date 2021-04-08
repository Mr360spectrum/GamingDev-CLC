using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopperMovement : MonoBehaviour
{
    //Declare variables to keep score
    int redScore = 0;
    int blueScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*.1F, Input.GetAxis("Vertical")*.1F, 0);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        //get the other object's tag
        string otherTag = other.gameObject.tag;

        //display some information in the console
        Debug.Log("other" + other.name + ", tag = " + otherTag);

        //Award points based on tag
        if (otherTag.Equals("Red"))
        {
            redScore++;
            Debug.Log("Red Score = " + redScore);
            other.gameObject.tag = "Neutral";
        }
        else if (otherTag.Equals("Blue"))
        {
            blueScore++;
            Debug.Log("Blue Score = " + blueScore);
            other.gameObject.tag = "Neutral";
        }
    }
}
