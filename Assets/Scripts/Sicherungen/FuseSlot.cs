using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseSlot : MonoBehaviour
{
    [SerializeField] public bool insideSlot;

    [SerializeField] public GameObject GameObjecIntSlot;

    [HideInInspector] public Transform _transformFuseSlot;
    //TODO floor

    private void Start()
    {
        _transformFuseSlot = gameObject.transform;
    }

    // void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Sicherung"))
    //     {
    //         GameObjecIntSlot = collision.gameObject;
    //
    //         insideSlot = true;
    //     }
    // }
    //
    // private void OnCollisionExit(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Sicherung"))
    //     {
    //         insideSlot = false;
    //     }
    // }
}