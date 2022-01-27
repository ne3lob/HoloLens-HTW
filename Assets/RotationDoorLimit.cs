using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationDoorLimit : MonoBehaviour
{
    [SerializeField] private Transform pivotDoor;
    public bool doorManipulate;

    public void CheckBoolDoorManipulate(bool b)
    {
        doorManipulate = b;
    }


    public void Update()
    {
        Debug.Log(pivotDoor.localRotation.y);
        if (doorManipulate && pivotDoor.localRotation.y < 0)
        {
            var localRotation = pivotDoor.localRotation;
            localRotation = Quaternion.Euler(localRotation.x, 0, localRotation.z);
            pivotDoor.localRotation = localRotation;
        }


        else if (doorManipulate && pivotDoor.localRotation.y > 1f)
        {
            var localRotation = pivotDoor.localRotation;
            localRotation = Quaternion.Euler(localRotation.x, 140, localRotation.z);
            pivotDoor.localRotation = localRotation;
        }
    }
}