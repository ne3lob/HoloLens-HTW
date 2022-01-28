using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseSecond : MonoBehaviour
{
    [SerializeField] private int amperFuseSecond = 16;
    [SerializeField] private GameObject labelFuseSecondOff;
    [SerializeField] private GameObject labelFuseSecondOn;

    public bool fuseSecondIsEnable=true;

    private void Start()
    {
        
    }


    public void FuseSecondSwitching()
    {
        switch (fuseSecondIsEnable)
        {
            case false:

                StartCoroutine(GetComponent<SwitcherLabel>().LabelCall(labelFuseSecondOn, 0.5f));
                fuseSecondIsEnable = true;
                break;
            case true:

                StartCoroutine(GetComponent<SwitcherLabel>().LabelCall(labelFuseSecondOff, 0.5f));
                fuseSecondIsEnable = false;
                break;
        }
    }
}