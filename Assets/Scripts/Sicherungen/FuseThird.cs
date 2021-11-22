using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseThird : MonoBehaviour
{
    [SerializeField] private GameObject labelFuseThirdOff;
    [SerializeField] private GameObject labelFuseThirdOn;

    public bool fuseThirdIsEnable=true;

    public void FuseThirdSwitching()
    {
        switch (fuseThirdIsEnable)
        {
            case false:

                StartCoroutine(GetComponent<SwitcherLabel>().LabelCall(labelFuseThirdOn, 0.5f));
                fuseThirdIsEnable = true;
                break;
            case true:

                StartCoroutine(GetComponent<SwitcherLabel>().LabelCall(labelFuseThirdOff, 0.5f));
                fuseThirdIsEnable = false;
                break;
        }
    }
}