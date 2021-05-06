using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    public string[] playerItems;

    // Start is called before the first frame update
    void Start()
    {
        // string[] playerItems = new string[4]{"pliers", "gold coin", "french to mandarin dictionary", "gum"};

        Debug.Log("The first item is: " + playerItems[0]);
        Debug.Log("The second item is: " + playerItems[1]);
        Debug.Log("The third item is: " + playerItems[2]);
        Debug.Log("The fourth item is: " + playerItems[3]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
