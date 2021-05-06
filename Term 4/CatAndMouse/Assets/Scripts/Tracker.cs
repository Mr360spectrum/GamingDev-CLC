using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker
{
    private GameObject source;
    private GameObject target;

    public Tracker(GameObject sourceObject, string targetName)
    {
        //Initialize source and target objects
        source = sourceObject;
        target = GameObject.Find(targetName);
    }

    //Return normalized (unit length 1) vector
    //in direction needed to travel
    public Vector2 GetDirection()
    {
        //Temporary target location
        Vector2 targetPos = target.transform.position;

        //Get current position from source object
        Vector2 sourcePos = source.transform.position;

        //Calculate direction vector from current
        //source to target
        Vector2 direction = targetPos - sourcePos;
        direction.Normalize();

        //Return direction vector
        return direction;
    }
}
