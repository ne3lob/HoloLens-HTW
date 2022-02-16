using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseSlot : MonoBehaviour
{
    [SerializeField] public bool insideSlot;
    [SerializeField] public bool isEmpty;

    [SerializeField] public GameObject GameObjecIntSlot;

    [HideInInspector] public Transform _transformFuseSlot;
    //TODO floor

    private void Start()
    {
        _transformFuseSlot = gameObject.transform;
    }
}