using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseFirst : MonoBehaviour
{
    [SerializeField] private Animator _switchAnimator;
    [SerializeField] private GameObject labelFuseFirstOff;
    [SerializeField] private GameObject labelFuseFirstOn;

    public bool fuseFirstIsEnable;

    public void FuseFirstSwitching()
    {
        switch (fuseFirstIsEnable)
        {
            case false:
                GetComponent<Switcher>().Switching(_switchAnimator, "SwitchFuse1_On");
                StartCoroutine(GetComponent<Switcher>().LabelCall(labelFuseFirstOn, 0.5f));
                fuseFirstIsEnable = true;
                break;
            case true:
                GetComponent<Switcher>().Switching(_switchAnimator, "SwitchFuse1_Off");
                StartCoroutine(GetComponent<Switcher>().LabelCall(labelFuseFirstOff, 0.5f));
                fuseFirstIsEnable = false;
                break;
        }
    }
}