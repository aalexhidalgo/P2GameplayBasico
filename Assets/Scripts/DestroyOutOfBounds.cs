using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float UpperLimit = 30f;
    private float LowerLimit = -10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Comida fallida
        if (transform.position.z > UpperLimit)
        {
            Destroy(gameObject);
        }
        //Animal fallido
        if (transform.position.z < LowerLimit)
        {
            Destroy(gameObject);
        }
    }
}
