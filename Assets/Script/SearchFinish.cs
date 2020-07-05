using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchFinish : MonoBehaviour
{
    public float customerSpeed;
    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = new Vector3(Random.Range(-65, 65), 4.5f, Random.Range(60, 100));
        Invoke("killCustomer", 15);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, customerSpeed); 
    }
    void killCustomer(){
        Destroy(gameObject);
    }
}
