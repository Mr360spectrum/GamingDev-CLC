using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public GameObject bird;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerScript bird = (collision.collider.GetComponent<PlayerScript>());
        if (bird != null && bird._launched) 
        {
            Destroy(gameObject);
        }
        
        NPCScript enemy = collision.collider.GetComponent<NPCScript>();
    }
}
