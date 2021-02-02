using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        transform.Rotate(0.0f, 0.0f, Input.GetAxis("Fire1"));
        transform.localScale += new Vector3(Input.GetAxis("Fire2"), Input.GetAxis("Fire2"), 0.0f);
    }
}
