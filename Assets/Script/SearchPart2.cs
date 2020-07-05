using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchPart2 : MonoBehaviour
{
    public Vector3 target;
    public float customerSpeed;
    public bool doneWalking = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GameObject dock = GameObject.Find("DockingStation");
        BoatDockCollider BdCollider = dock.GetComponent<BoatDockCollider>();

        GameObject Player = GameObject.Find("Player");
        capacityManager capacityScript = Player.GetComponent<capacityManager>(); 
        DropOffCollider dropOff = Player.GetComponent<DropOffCollider>();

        target = Player.transform.position + new Vector3(0, 2, 0);
        // makes the customers go towards a certain target point
        if(BdCollider.boatInDock == true && capacityScript.customersOnBoat < capacityScript.boatCapacity && doneWalking == false){
            transform.position = Vector3.MoveTowards(transform.position, target, customerSpeed);
        }
    }
}
