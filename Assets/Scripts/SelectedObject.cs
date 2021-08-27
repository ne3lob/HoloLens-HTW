using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SelectedObject : MonoBehaviour
{
    [FormerlySerializedAs("SelectedObjectList")]
    public List<GameObject> selectedObjectList;

    // Start is called before the first frame update
    private void Start()
    {
        selectedObjectList = new List<GameObject>();
    }
}