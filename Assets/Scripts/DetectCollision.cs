using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherCollider)
    {
        //Destruyo la comida
        Destroy(gameObject);

        //Desaparece el animal una vez alimentado
        Destroy(otherCollider.gameObject);
    }
}
