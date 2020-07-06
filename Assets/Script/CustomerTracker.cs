using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerTracker : MonoBehaviour
{
    GameObject onBoatDisplay;
    Text onBoatDisplayText;
    public capacityManager capacityMGer;
    string onBoat;
    string originalText;
    void Start()
    {
        // modify text
        onBoatDisplay = GameObject.Find("CustomersOnBoatText");
        onBoatDisplayText = onBoatDisplay.GetComponent<Text>();
        originalText = onBoatDisplayText.text;
    }

    // Update is called once per frame
    void Update()
    {
        onBoat = (capacityMGer.customersOnBoat).ToString();
        onBoatDisplayText.text = originalText + onBoat;
    }
}
