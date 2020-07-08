using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class pointsController : MonoBehaviour
{
    public double points;
    // Start is called before the first frame update
    void Start()
    {
        if(name == "100"){
            points = 500;
        } else{
            points = 10;
        }
        InvokeRepeating("removePoints", 0, 1f);
    }
    void removePoints(){
        points *= 0.95f;
        points = Convert.ToDouble(points);
    }
}
