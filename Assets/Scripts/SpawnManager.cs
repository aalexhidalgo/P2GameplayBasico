using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] AnimalPrefabs;
    private Vector3 SpawnPosition;

    private float XRange = 15f;
    private float SpawnZ = 25f;

    private float StartTime =2f;
    private float RepeatRate= 1.5f;

    private float RandomX;
    private int RandomIndex;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", StartTime, RepeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 RandomSpawnPosition()
    {
        RandomX = Random.Range(-XRange, XRange);
        return new Vector3(RandomX, 0, SpawnZ); 
    }

    
    public void SpawnAnimal()
    {
        RandomIndex = Random.Range(0, AnimalPrefabs.Length);
        SpawnPosition = RandomSpawnPosition();
        Instantiate(AnimalPrefabs[RandomIndex], SpawnPosition, AnimalPrefabs[RandomIndex].transform.rotation);
    }
    
}
