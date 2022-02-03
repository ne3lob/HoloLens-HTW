using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse : MonoBehaviour
{
    [SerializeField] private int amperFuseSecond;
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
}