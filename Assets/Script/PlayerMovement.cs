using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform playerTF;
    public float forwardForce;
    public float backwardsForce;
    public float rotationScale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w")){
            rb.AddRelativeForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if(Input.GetKey("s")){
            rb.AddRelativeForce(0, 0, -backwardsForce * Time.deltaTime, ForceMode.VelocityChange);
        } 
        if(Input.GetKey("d")){
            playerTF.Rotate(0f, rotationScale, 0f);
        }
        if(Input.GetKey("a")){
            playerTF.Rotate(0f, -rotationScale, 0f);
        }
   }
}
