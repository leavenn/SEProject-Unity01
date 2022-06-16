using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] spawnPoints = new GameObject [4];
    public GameObject[] obstPrefab;
    public Material []obstMaterials;
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
            int randPrefab = Random.Range(0, obstPrefab.Length);
            int randRotation = Random.Range(-20, 20);

            Instantiate(obstPrefab[randPrefab], spawnPoints[i].transform.position, Quaternion.Euler(new Vector3(0, randRotation, 0)));

            int randMaterial = Random.Range(0, obstMaterials.Length);
            
            obstPrefab[randPrefab].GetComponent<MeshRenderer>().material = obstMaterials[randMaterial];


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

