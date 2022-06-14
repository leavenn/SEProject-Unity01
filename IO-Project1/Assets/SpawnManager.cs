using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] spawnPoints = new GameObject [4];
    public GameObject obstPrefab;

    private float nextSpawnTime;
    public float spawnDelay = 3f;

    private void Update()
    {
        if (CanSpawn())
        {
            SpawnObstacle();
        }
    }

    private void SpawnObstacle()
    {
        nextSpawnTime = Time.timeScale + spawnDelay;

        int freeSpace = Random.Range(0, 3);
        for(int i = 0; i < spawnPoints.Length; i++)
        {
            if(i == freeSpace) { continue; }
            Instantiate(obstPrefab, spawnPoints[i].transform.position, spawnPoints[i].transform.rotation);
        }
        
    }
    
    private bool CanSpawn()
    {
        return Time.time >= nextSpawnTime;
    }


}

