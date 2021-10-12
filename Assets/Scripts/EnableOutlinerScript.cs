using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;

public class EnableOutlinerScript : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<MeshOutline>().enabled = false;
    }
}