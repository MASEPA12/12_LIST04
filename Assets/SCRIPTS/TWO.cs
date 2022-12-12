using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TWO : MonoBehaviour
{
    public float CM;
    private float INCH;

   void Start()
    {
        //if there's any value written in the cm, it has to calculate how many inches they are
        if (CM != 0)
        {
            CMtoINCHES(CM);
        }
    }

    private float CMtoINCHES(float cm)
    {
        float inch;
        inch = cm * 0.3937f;
        Debug.Log($"{cm}cm are {inch}inches");

        return inch;
    }

}
