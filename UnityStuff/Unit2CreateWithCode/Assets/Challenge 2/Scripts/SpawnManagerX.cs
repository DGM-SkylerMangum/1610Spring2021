using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float startDelay = 1.0f;
    private int spawnInterval;
    int ballIndex;
    // Start is called before the first frame update
    void Start()
    {
        ballIndex = Random.Range(0, ballPrefabs.Length);
        spawnInterval = Random.Range(3, 5);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }
    void Update()
    {
        ballIndex = Random.Range(0, ballPrefabs.Length);
        spawnInterval = Random.Range(3, 5);
    }
    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        ballIndex = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        // instantiate ball at random spawn location
        spawnInterval = Random.Range(3, 5);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
