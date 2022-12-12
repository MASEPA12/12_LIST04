using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THREE : MonoBehaviour
{
    //variable declaration;
    public float upperLimit;
    public float lowerLimit;

    
    void Start()
    {   //if some of the limits is not 0, the function CreateARandomNumber will calculate a random number between the two limits.
        if(upperLimit != 0 || lowerLimit != 0) 
        {
            CreateARandomNumber(upperLimit, lowerLimit);
        }
    }

    private float CreateARandomNumber(float up, float down)
    {
        float randomNumber;
        //randomNumber will be an aleatori number between up and down
        randomNumber = Random.Range(up, down);
        Debug.Log($"The random number between {up} and {down} is {randomNumber}");
        return randomNumber;
    }
}
