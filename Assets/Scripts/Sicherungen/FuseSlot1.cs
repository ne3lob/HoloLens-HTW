using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseSlot1 : MonoBehaviour
{
    [SerializeField] public bool insideSlot1;

    [SerializeField] public GameObject GameObjecIntSlot1;

    [HideInInspector] public Transform _transformFuseSlot1;
    //TODO floor

    private void Start()
    {
        _transformFuseSlot1 = gameObject.transform;
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Sicherung")
        {
            GameObjecIntSlot1 = collision.gameObject;

            insideSlot1 = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Sicherung")
        {
            insideSlot1 = false;
            Debug.Log("exit from Slot1");
        }
    }
}