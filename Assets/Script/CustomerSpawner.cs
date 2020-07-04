using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public GameObject customerPrefab;
    public float centerPoint;
    public float spawnRadius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnFood();
    }

    public void SpawnFood(){
        Vector3 position = new Vector3(Random.Range(-spawnRadius/2, spawnRadius/2), 1, Random.Range(-spawnRadius/2, spawnRadius/2));

        Instantiate(customerPrefab, position, Quaternion.identity);
    }
}
