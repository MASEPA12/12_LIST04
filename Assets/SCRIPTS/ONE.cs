using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONE : MonoBehaviour
{
    public int totalPOINTS;


    // Inside the uptade we say that when we click the mouse, we'll call the function.
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pointsSTORAGE(5);
        }
    }
    // THe function rewrites the value of "total" in order to sum the points.
    private void pointsSTORAGE(int totalToAdd)
    {
        totalPOINTS = totalToAdd + totalPOINTS;
        Debug.Log($"TOTAL POINTS = {totalPOINTS}"); 
    }
}
