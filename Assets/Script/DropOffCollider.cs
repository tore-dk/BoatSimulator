using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOffCollider : MonoBehaviour
{
    public float exitSpeed;
    private bool inDropOff = false;
    public GameObject servedPrefab;
    Vector3 offset = new Vector3(0, 2, 0);
    List<int> customerPointsList;
    GameObject ScoreManager;
    public float points;
    void Start(){
        ScoreManager = GameObject.Find("ScoreManager");
        //get total points
        points = ScoreManager.GetComponent<CustomerTracker>().totalPoints;
    }
    void Update(){
        // get customer points
        customerPointsList = GetComponent<capacityManager>().customerPoints;
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
            Instantiate(servedPrefab, transform.position + offset, Quaternion.identity);
            // add points and remove object from list
            points += customerPointsList[0];
            customerPointsList.RemoveAt(0);
            cpManager.customersOnBoat--;
        } else{
            CancelInvoke("ExitBoat");
        }
    }
}
