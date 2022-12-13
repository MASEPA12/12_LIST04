using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOUR : MonoBehaviour
{   //we set the array with an index that we'll use it to get a random number between it's start and it's end.
    public string[] Array;
    private int ArrayIndex;

    private void Start()
    {
        randomElement();
    }
    private int randomElement()
    {   //define the Array index as the range between 0 and it's lengh                       
        ArrayIndex = Random.Range(0, Array.Length);
        Debug.Log($"The aleatorian element is {Array[ArrayIndex]}");
        return ArrayIndex ;
    }
}
