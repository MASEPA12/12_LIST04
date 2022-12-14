using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIVE : MonoBehaviour
{
    public float Xlimit;
    private float Ylimit;
    public float Zlimit;

    void Start()
    {
        if (isout(Xlimit, Ylimit, Zlimit) == true)
        {
            Debug.Log("The player is out of bounds");
        }
    }

    private bool isout(float LimX, float LimY, float LimZ)
    {   //if the position on x,y or z is out of the limits, it will be true (will be out of bounds)

        if (transform.position.x > LimX || transform.position.x < -LimX)
        {
            return true;
        }
        if (transform.position.z > LimZ || transform.position.z < -LimZ)
        {
            return true;
        }
        if (transform.position.y > LimY || transform.position.y < -LimY)
        {
            return true;
        }
        // if is in the bounds won't be out of bouds (false)
        return false;
    }
}



