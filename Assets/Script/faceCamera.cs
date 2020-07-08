using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceCamera : MonoBehaviour
{
    // Start is called before the first frame update
    Transform cameraTransform;
    GameObject cameraObject;
    void Start()
    {
        cameraObject = GameObject.Find("Camera Target");

        cameraTransform = cameraObject.transform;
/*        transform.localEulerAngles = new Vector3(0, 180, 0);
        transform.LookAt(Camera.main.transform); */
        transform.rotation = Quaternion.Euler(cameraTransform.rotation.eulerAngles);
    }
}
