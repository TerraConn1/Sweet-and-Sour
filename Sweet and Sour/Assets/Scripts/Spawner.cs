using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;
    public Transform[] spawnSpots;
    private float timeBetweenSpawns;
    public float startTimeBtwSpawns;

    void Start()
    {
        timeBetweenSpawns = startTimeBtwSpawns;
    }

    void Update()
    {
        if (timeBetweenSpawns <= 0)
        {
            int randPos = Random.Range(0, spawnSpots.Length);
            Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
            timeBetweenSpawns = startTimeBtwSpawns;

        } else
        {
            timeBetweenSpawns -= Time.deltaTime;
        }
    }


}
