using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseFirst : MonoBehaviour
{
    [SerializeField] private GameObject labelFuseFirstOff;
    [SerializeField] private GameObject labelFuseFirstOn;

    public bool fuseFirstIsEnable=true;

    public void FuseFirstSwitching()
    {
        switch (fuseFirstIsEnable)
        {
            case false:

                StartCoroutine(GetComponent<SwitcherLabel>().LabelCall(labelFuseFirstOn, 0.5f));
                fuseFirstIsEnable = true;
                break;
            case true:

                StartCoroutine(GetComponent<SwitcherLabel>().LabelCall(labelFuseFirstOff, 0.5f));
                fuseFirstIsEnable = false;
                break;
        }
    }
}