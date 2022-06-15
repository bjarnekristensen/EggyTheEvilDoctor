using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] hazards;
    public GameObject egg;

    float timeBetweenEggsTimer;
    public float startTimeBetweenEggs = 2.0f;

    float timeBetweenSpawns;
    public float startTimeBetweenSpawns = 1.25f;

    public float minTimeBetweenSpawns = 0.4f;
    public float decrease = 0.1f;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        timeBetweenSpawns = startTimeBetweenSpawns;
        timeBetweenEggsTimer = startTimeBetweenEggs;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (timeBetweenSpawns <= 0)
            {
                Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                GameObject randomHazard = hazards[Random.Range(0, hazards.Length)];

                Instantiate(randomHazard, randomSpawnPoint.position, Quaternion.identity);

                if (startTimeBetweenSpawns > minTimeBetweenSpawns)
                {
                    startTimeBetweenSpawns -= decrease;
                }

                timeBetweenSpawns += startTimeBetweenSpawns;
            }
            else
            {
                timeBetweenSpawns -= Time.deltaTime;
            }

            if (timeBetweenEggsTimer <= 0)
            {
                Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

                Instantiate(egg, randomSpawnPoint.position, Quaternion.identity);

                timeBetweenEggsTimer += startTimeBetweenEggs;
            }
            else
            {
                timeBetweenEggsTimer -= Time.deltaTime;
            }
        }
    }
}
