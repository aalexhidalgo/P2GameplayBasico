using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float Speed = 5f;
    

    // Update is called once per frame
    void Update()
    {
        //Movimiento hacia delante
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}
