using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse : MonoBehaviour
{
    [SerializeField] private int Ampere;
    [SerializeField] private GameObject labelFuseOff;
    [SerializeField] private GameObject labelFuseOn;

    public bool fuseIsEnable = true;


    public void FuseSwitching()
    {
        switch (fuseIsEnable)
        {
            case false:

                StartCoroutine(GetComponent<SwitcherLabel>().LabelCall(labelFuseOn, 0.5f));
                fuseIsEnable = true;
                break;
            case true:

                StartCoroutine(GetComponent<SwitcherLabel>().LabelCall(labelFuseOff, 0.5f));
                fuseIsEnable = false;
                break;
        }
    }
    

    void OnCollisionEnter(Collision collision)
    {
        FuseSlot script = collision.collider.GetComponent<FuseSlot>();
        if (script != null && collision.gameObject.CompareTag("FuseSlot") && script.insideSlot == false)
        {
            script.insideSlot = true;
            script.GameObjecIntSlot = this.gameObject;
            Debug.Log("collide (name) : " + collision.collider.gameObject.name);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        FuseSlot script = collision.collider.GetComponent<FuseSlot>();
        if (script != null && collision.gameObject.CompareTag("FuseSlot") && script.insideSlot)
        {
            script.insideSlot = false;
        }
    }
}