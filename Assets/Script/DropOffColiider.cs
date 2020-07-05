using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOffColiider : MonoBehaviour
{
    public float exitSpeed;
    private bool inDropOff = false;
    public GameObject customerPrefab;
    void Start(){
    }
    void OnTriggerEnter(Collider collider){
        if(collider.name == "EndDock"){
            inDropOff = true;
            capacityManager cpManager = gameObject.GetComponent<capacityManager>();
            InvokeRepeating("ExitBoat", exitSpeed * cpManager.customersOnBoat, exitSpeed);
        }
   }
    void OnTriggerExit(Collider collider){
        if(collider.name == "EndDock"){
            inDropOff = false;
        }
    }
    void ExitBoat(){
        capacityManager cpManager = gameObject.GetComponent<capacityManager>();
        if(cpManager.customersOnBoat > 0 && inDropOff == true){
            Debug.Log("Customer dropped off");
//            Vector3 dropOffPos = new Vector3(Random.Range(), Random.Range(), Random.Range());
            Vector3 dropOffPos = new Vector3(1, 10, 1);
            Instantiate(customerPrefab, dropOffPos, Quaternion.identity);
            cpManager.customersOnBoat--;
        }
    }
}
