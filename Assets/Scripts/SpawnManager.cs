using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] AnimalPrefabs;
    public Vector3 SpawnPosition= new Vector3(0, 0, 25);
    private float XRange = 15f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 2, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 RandomSpawnPosition()
    {
        float RandomX = Random.Range(-XRange, XRange);
        return new Vector3(RandomX, 0, 25); 
    }

    
    public void SpawnAnimal()
    {
        int RandomIndex = Random.Range(0, AnimalPrefabs.Length);
        SpawnPosition = RandomSpawnPosition();
        Instantiate(AnimalPrefabs[RandomIndex], SpawnPosition, AnimalPrefabs[RandomIndex].transform.rotation);
    }
    
}
