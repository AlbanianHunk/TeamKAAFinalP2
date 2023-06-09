using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnPosX = 8;
    private float spawnPosY = 0;
    private float spawnPosZ = -15;



    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);

        // instantiate ball at random spawn location
        int ballNumber = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ballNumber], spawnPos, ballPrefabs[ballNumber].transform.rotation);
    }

}
