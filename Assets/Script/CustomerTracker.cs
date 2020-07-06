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
    GameObject totalPointsObject;
    Text totalPointsText; 
    public DropOffCollider dropOffCollider;
    public capacityManager capacityMGer;
    string onBoat;
    string originCustomersOnBoatText;
    string originMaximumSpaceText;
    string originTotalPointsText;
    string totalSpace;
    public float totalPoints;
    string points;

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
        // get total points text
        totalPointsObject = GameObject.Find("TotalPointsText");
        totalPointsText = totalPointsObject.GetComponent<Text>();
        originTotalPointsText = totalPointsText.text;
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
        // update and recieve total points
        points = (dropOffCollider.points).ToString();
        totalPointsText.text = originTotalPointsText + points;
    }
}
