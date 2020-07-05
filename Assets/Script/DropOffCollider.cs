using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOffCollider : MonoBehaviour
{
    public float exitSpeed;
    private bool inDropOff = false;
    public GameObject servedPrefab;
    Vector3 offset = new Vector3(0, 2, 0);
    void Start(){
    }
    void OnTriggerEnter(Collider collider){
        if(collider.name == "EndDock"){
            inDropOff = true;
            capacityManager cpManager = gameObject.GetComponent<capacityManager>();
            InvokeRepeating("ExitBoat", exitSpeed, exitSpeed);
        }
   }
    void OnTriggerExit(Collider collider){
        if(collider.name == "EndDock"){
            inDropOff = false;
            CancelInvoke("ExitBoat");
        }
    }
    void ExitBoat(){
        capacityManager cpManager = gameObject.GetComponent<capacityManager>();
        if(cpManager.customersOnBoat > 0){
//            Vector3 dropOffPos = new Vector3(1, 10, 1);
            Instantiate(servedPrefab, transform.position + offset, Quaternion.identity);
            cpManager.customersOnBoat--;
        } else{
            CancelInvoke("ExitBoat");
        }
    }
}
