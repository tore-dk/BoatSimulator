using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatDockCollider : MonoBehaviour
{
    public bool boatInDock;
    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Player"){
            boatInDock = true;
        }
    }
    void OnTriggerExit(Collider collider){
        if(collider.gameObject.tag == "Player"){
            boatInDock = false;
        }
    }
}
