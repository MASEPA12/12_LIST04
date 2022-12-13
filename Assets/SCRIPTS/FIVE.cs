using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIVE : MonoBehaviour
{
    //first we set the bounds; for example 2 and -2 is the bouds of x
    public float X; //BOUND front/back
    public float Z; //bound right/left

    // Start is called before the first frame update
    void Start()
    {
        if (isOutOfBounds(X, Z))
        {
            Debug.Log($"The player is out of bounds");
        }
    }

    private bool isOutOfBounds(float x, float z)
    {
        if(transform.position.x > x || transform.position.x < -x)
        {
            return true;
        }
        if(transform.position.z > z || transform.position.z < -z)
        {
            return true;
        }
        return false;
    }
}
