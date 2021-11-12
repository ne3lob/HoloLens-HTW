using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities.Solvers;

public class StopTapPlaceContent : MonoBehaviour
{
    private GameObject _contentObject;
    private TapToPlace tapToPlace;
    [HideInInspector] public bool disablePlacement;

    private void Awake()
    {
        disablePlacement = false;
        _contentObject = GameObject.Find("ContentHololectric");
        tapToPlace = _contentObject.GetComponent<TapToPlace>();
    }

    void Update()
    {
        if (disablePlacement)
        {
            tapToPlace.StopPlacement();
            tapToPlace.enabled = false;
        }
           

    }

    // public void ChangeBool()
    // {
    //     disablePlacement = true;
    // }
}