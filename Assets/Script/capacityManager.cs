using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class capacityManager : MonoBehaviour
{
    public List<int> customerPoints = new List<int>();
    public int boatCapacity;
    public int customersOnBoat;
    pointsController pointsController;

    void OnTriggerEnter(Collider collider){
            if(collider.gameObject.tag == "Customer" && boatCapacity > customersOnBoat){
                pointsController = (collider.GetComponent<pointsController>());
                customerPoints.Add((int)Math.Round(pointsController.points));
                Destroy(collider.gameObject);
                customersOnBoat++;
            }
        }
}    
