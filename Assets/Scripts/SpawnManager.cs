using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject AnimalPrefab;
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
            SpawnPosition = RandomSpawnPosition();
            Instantiate(AnimalPrefab, SpawnPosition, AnimalPrefab.transform.rotation);
    }
}
