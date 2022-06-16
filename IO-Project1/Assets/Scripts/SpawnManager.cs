using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] spawnPoints = new GameObject [4];
    public GameObject[] obstPrefab;
    public Material []obstMaterials;
    public GameObject scorePrefab;

    public int obstRotation = 10;

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

        int freeSpace = Random.Range(0, spawnPoints.Length);
        int randMaterial = Random.Range(0, obstMaterials.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            int randPrefab = Random.Range(0, obstPrefab.Length);
            int randRotation = Random.Range(-obstRotation, obstRotation);
            
            if (i == freeSpace) { 
                SpawnScorePoint(i);
                continue;
            }
            obstPrefab[randPrefab].GetComponent<MeshRenderer>().material = obstMaterials[randMaterial];

            Instantiate(obstPrefab[randPrefab], spawnPoints[i].transform.position, Quaternion.Euler(new Vector3(0, randRotation, 0)));

            

            
        }
        
    }
    
    private bool CanSpawn()
    {
        return Time.time >= nextSpawnTime;
    }

    private void SpawnScorePoint(int i)
    {
        Instantiate(scorePrefab, new Vector3(0,spawnPoints[i].transform.position.y,spawnPoints[i].transform.position.z), spawnPoints[i].transform.rotation);
    }

}

