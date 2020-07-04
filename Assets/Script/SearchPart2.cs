using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchPart2 : MonoBehaviour
{
    public Vector3 target;
    public float customerSpeed;
    bool hasReached = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // makes the customers go towards a certain target point
        if(hasReached == false){
            transform.position = Vector3.MoveTowards(transform.position, target, customerSpeed);
        }
        if(transform.position == target){
            hasReached = true;
        }
    }
}
