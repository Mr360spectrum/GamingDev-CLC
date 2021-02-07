using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log(gameObject.name + "hit by " + other.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(gameObject.name + " triggered by " + other.gameObject.name);
    }
}
