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
                customerPoints.Add(int.Parse(collider.name));
                Destroy(collider.gameObject);
                customersOnBoat++;
            }
        }
}    
