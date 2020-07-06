using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerTracker : MonoBehaviour
{
    GameObject maximumSpace;
    Text maximumSpaceText;
    GameObject onBoatDisplay;
    Text onBoatDisplayText;
    public capacityManager capacityMGer;
    string onBoat;
    string originCustomersOnBoatText;
    string originMaximumSpaceText;
    string totalSpace;

    void Start()
    {
        // get customers on boat text
        onBoatDisplay = GameObject.Find("CustomersOnBoatText");
        onBoatDisplayText = onBoatDisplay.GetComponent<Text>();
        originCustomersOnBoatText = onBoatDisplayText.text;
        // get total space available text
        maximumSpace = GameObject.Find("MaxCapacityText");
        maximumSpaceText = maximumSpace.GetComponent<Text>();
        originMaximumSpaceText = maximumSpaceText.text;
    }

    // Update is called once per frame
    void Update()
    {
        // update sutomers on boat text
        onBoat = (capacityMGer.customersOnBoat).ToString();
        onBoatDisplayText.text = originCustomersOnBoatText + onBoat;
        // update total space available text
        totalSpace = (capacityMGer.boatCapacity).ToString();
        maximumSpaceText.text = originMaximumSpaceText + totalSpace;
    }
}
