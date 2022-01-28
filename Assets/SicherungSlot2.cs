using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SicherungSlot2 : MonoBehaviour
{
    public bool insideSlot2;

    public GameObject colGameObjectSlot2;
    [SerializeField] public Transform _transformSicherungSlot2;
    [SerializeField] private Transform _transformSicherungFloor;

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Sicherung")
        {
            colGameObjectSlot2 = collision.gameObject;
            Debug.Log("Do something else here");
            insideSlot2 = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Sicherung")
        {
            insideSlot2 = false;
        }
    }
}