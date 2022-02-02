using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using UnityEngine;

public class RotationDoorLimit : MonoBehaviour
{
    [SerializeField] private Transform pivotDoor;
    public bool doorManipulate;
    public BoundsControl control;

    public void CheckBoolDoorManipulate(bool b)
    {
        doorManipulate = b;
        control = GetComponent<BoundsControl>();
    }


    public void Update()
    {
        Debug.Log(pivotDoor.localRotation.eulerAngles.y);
        if (doorManipulate && pivotDoor.localRotation.eulerAngles.y > 308f)
        {
            Debug.Log("tut");
            StartCoroutine(LoadScriptBoundsControl());
             var localRotation = pivotDoor.transform.localRotation;
             localRotation = Quaternion.Euler(localRotation.x, 308, localRotation.z);
             pivotDoor.transform.localRotation = localRotation;
        }


        else if (doorManipulate && pivotDoor.localRotation.eulerAngles.y < 179f)
        {
            StartCoroutine(LoadScriptBoundsControl());
             var localRotation = pivotDoor.transform.localRotation;
             localRotation = Quaternion.Euler(localRotation.x, 180, localRotation.z);
             pivotDoor.transform.localRotation = localRotation;
        }
    }

    public IEnumerator LoadScriptBoundsControl()
    {
        control.Active = false;
        yield return new WaitForSeconds(0.1f);
        control.Active = true;
    }
}