using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResidualCurrentDevice : MonoBehaviour
{
    //Door Handel Animator

    [SerializeField] private GameObject labelFiOff;
    [SerializeField] private GameObject labelFiOn;


    public bool fiIsEnable;

    public void RCSwitching()
    {
        switch (fiIsEnable)
        {
            case false:

                StartCoroutine(GetComponent<SwitcherLabel>().LabelCall(labelFiOn, 0.5f));
                fiIsEnable = true;
                break;
            case true:

                StartCoroutine(GetComponent<SwitcherLabel>().LabelCall(labelFiOff, 0.5f));
                fiIsEnable = false;
                break;
        }
    }
}