using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capacityManager : MonoBehaviour
{
    public List<int> customerPoints = new List<int>();
    public int boatCapacity;
    public int customersOnBoat;

    void OnTriggerEnter(Collider collider){
            if(collider.gameObject.tag == "Customer" && boatCapacity > customersOnBoat){
                if(collider.name == "100"){
                    customerPoints.Add(500);
                } else{
                    customerPoints.Add(10);
                }
                Destroy(collider.gameObject);
                customersOnBoat++;
            }
        }
}    
