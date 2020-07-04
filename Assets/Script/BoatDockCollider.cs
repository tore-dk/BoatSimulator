using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatDockCollider : MonoBehaviour
{
    public bool boatInDock;
    void OnTriggerEnter(){
        boatInDock = true;
    }
    void OnTriggerExit(){
        boatInDock = false;
    }
}
