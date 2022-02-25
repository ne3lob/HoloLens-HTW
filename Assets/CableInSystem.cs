using System.Collections;
using System.Collections.Generic;
using OculusSampleFramework;
using UnityEngine;
using UnityEngine.Serialization;

public class CableInSystem : MonoBehaviour
{
    [SerializeField] public int cabelSizeInside;
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cable"))
        {
            cabelSizeInside = collision.gameObject.GetComponent<Cable>().cableSize;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("WallChaser"))
        {
            
        }
        
    }
}