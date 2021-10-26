using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResidualCurrentDevice : MonoBehaviour
{
    //Door Handel Animator
    [SerializeField] private Animator _switchAnimator;
    [SerializeField] private GameObject labelFiOff;
    [SerializeField] private GameObject labelFiOn;


    public bool fiIsEnable;

    public void RCSwitching()
    {
        switch (fiIsEnable)
        {
            case false:
                GetComponent<Switcher>().Switching(_switchAnimator, "SwitchFi_On");
                StartCoroutine(GetComponent<Switcher>().LabelCall(labelFiOn, 0.5f));
                fiIsEnable = true;
                break;
            case true:
                GetComponent<Switcher>().Switching(_switchAnimator, "SwitchFi_Off");
                StartCoroutine(GetComponent<Switcher>().LabelCall(labelFiOff, 0.5f));
                fiIsEnable = false;
                break;
        }
    }
}