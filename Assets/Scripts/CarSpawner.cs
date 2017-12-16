using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour {

    public float spawnDelay = .3f;
    float nextTimeToSpawn = 0f;
    public GameObject car;
    public Transform[] spawnPoints;

    void Update()
    {
        if(nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnCar()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Transform spawnpoint = spawnPoints[index];
        Instantiate(car,spawnpoint.position,spawnpoint.rotation);
    }
}
