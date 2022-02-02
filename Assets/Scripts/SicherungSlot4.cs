using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SicherungSlot4 : MonoBehaviour
{
    public bool insideSlot4;

    public GameObject colGameObjectSlot4;
    [SerializeField] public Transform _transformSicherungSlot4;
    [SerializeField] private Transform _transformSicherungFloor;

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Sicherung")
        {
            colGameObjectSlot4 = collision.gameObject;
            Debug.Log("Do something else here");
            insideSlot4 = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Sicherung")
        {
            insideSlot4 = false;
        }
    }
}