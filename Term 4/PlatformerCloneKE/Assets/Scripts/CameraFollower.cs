using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform target;
    public Transform leftbounds;
    public Transform rightbounds;

    private float camWidth, camHeight, levelminX, levelmaxX;

    public float smoothDampTime = 0.15f;
    private Vector3 smoothDampVelocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //Calculate camera size
        camWidth = Camera.main.orthographicSize * 2;
        camHeight = camHeight * Camera.main.aspect;

        //Getting width of our bounds right and left
        float leftBoundWidth = leftbounds.GetComponentInChildren<SpriteRenderer>().bounds.size.x / 2;
        float rightBoundWidth = rightbounds.GetComponentInChildren<SpriteRenderer>().bounds.size.x / 2;
    
        //Setting the min and max x coords
        levelminX = leftbounds.position.x + leftBoundWidth + (camWidth / 2);
        levelmaxX = rightbounds.position.x - rightBoundWidth - (camWidth / 2);
    }

    //Update is called once per frame
    void Update()
    {
        //Binding the camera to the player and the bounds;
        //This will set the player as the target of the camera until
        //the camera hits the bounds, then it will switch the target
        //to the bounds and stop the camera moving with the player
        float targetX = Mathf.Max(levelminX, Mathf.Min(levelmaxX, target.position.x));

        float x = Mathf.SmoothDamp(transform.position.x, targetX, ref smoothDampVelocity.x, smoothDampTime);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
