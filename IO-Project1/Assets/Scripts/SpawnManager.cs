using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] spawnPoints = new GameObject [4];
    public GameObject obstPrefab;
    public GameObject scorePrefab;

    private float nextSpawnTime;
    public float spawnDelay = 1f;

    private void Update()
    {
        if (CanSpawn())
        {
            SpawnObstacle();
        }
    }

    private void SpawnObstacle()
    {
        nextSpawnTime = Time.time + spawnDelay;

        int freeSpace = Random.Range(0, 3);
        for(int i = 0; i < spawnPoints.Length; i++)
        {
            if(i == freeSpace) { 
                SpawnScorePoint(i);
                continue;
            }

            Instantiate(obstPrefab, spawnPoints[i].transform.position, spawnPoints[i].transform.rotation);
        }
        
    }
    
    private bool CanSpawn()
    {
        return Time.time >= nextSpawnTime;
    }

    private void SpawnScorePoint(int i)
    {
        Instantiate(scorePrefab, new Vector3(0,1,spawnPoints[i].transform.position.z), spawnPoints[i].transform.rotation);
    }

}

