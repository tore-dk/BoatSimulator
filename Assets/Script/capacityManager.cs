﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capacityManager : MonoBehaviour
{
    public int boatCapacity;
    public int customersOnBoat;

    void OnTriggerEnter(Collider collider){
            if(collider.gameObject.tag == "Customer" && boatCapacity > customersOnBoat){
                Debug.Log("Customer fundet!");
                Destroy(collider.gameObject);
                customersOnBoat++;
            }
        }
}    