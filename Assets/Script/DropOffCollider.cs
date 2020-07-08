using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOffCollider : MonoBehaviour
{
    public float exitSpeed;
    private bool inDropOff = false;
    public GameObject servedPrefab;
    public GameObject pointsText;
    Vector3 offset = new Vector3(0, 2, 0);
    List<int> customerPointsList;
    GameObject ScoreManager;
    public float points;
    private GameObject tempCustomer;
    Material goldenMat;
    GameObject popText;


    void Start(){
        // get golden material
        goldenMat = Resources.Load("RareCustomerMat", typeof(Material)) as Material;
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
            // make customer golden if it is worth that much
            tempCustomer = Instantiate(servedPrefab, transform.position + offset, Quaternion.identity);

            // crate text
            popText = Instantiate(pointsText, transform.position + new Vector3(0, 5, 0), Quaternion.identity);

            // golden customer 
            if(customerPointsList[0] == 500){
                // render golden material
                tempCustomer.GetComponent<Renderer>().material = goldenMat;
            }
            // text showing the amount of points
            popText.GetComponent<TextMesh>().text = customerPointsList[0].ToString(); 

            // add points and remove object from list
            points += customerPointsList[0];
            customerPointsList.RemoveAt(0);
            cpManager.customersOnBoat--;

        } else{
            CancelInvoke("ExitBoat");
        }
    }
}
