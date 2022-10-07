using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject SpawnManagerObj;
    private Vector3 spawnPos = new Vector3(25, .5f, 0);
    public float startDelay = 1;
    public float repeatRate = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, SpawnManagerObj.transform.position, obstaclePrefab.transform.rotation);
    }
}
