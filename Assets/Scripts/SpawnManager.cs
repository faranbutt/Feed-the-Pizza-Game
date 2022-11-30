using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    private float spawnRangeX = 14;
    private float spawnPosZ = 20;
    private float startTime = 2f;
    private float TimeInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("RandomSpawnAnimal",startTime,TimeInterval); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomSpawnAnimal(){
        int animalIndex = Random.Range(0,animals.Length); 
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
        Instantiate(animals[animalIndex], spawnPos, animals[animalIndex].transform.rotation);
    }
}
