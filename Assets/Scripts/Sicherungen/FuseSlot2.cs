using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseSlot2 : MonoBehaviour
{
    [SerializeField] public bool insideSlot2;

    [SerializeField] public GameObject GameObjecIntSlot2;

    [HideInInspector] public Transform _transformFuseSlot2;
    //TODO floor

    private void Start()
    {
        _transformFuseSlot2 = gameObject.transform;
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Sicherung")
        {
            GameObjecIntSlot2 = collision.gameObject;

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