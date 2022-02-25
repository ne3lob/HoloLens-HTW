using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

public class Multimetr : MonoBehaviour
{
    [SerializeField] private List<GameObject> fuseBoxObjects;
    [SerializeField] private GameObject multimeterBase;


    private Vector3 _startPositionMultimeterBase;

    private int _fistConnectionWithMultimetr;

    public void SaveStartCoordinate()
    {
        if (_fistConnectionWithMultimetr < 1)
        {
            _startPositionMultimeterBase = multimeterBase.transform.position;


            _fistConnectionWithMultimetr++;
        }
    }

    public void SwitchScripts(bool enable)
    {
        foreach (var obj in fuseBoxObjects)
        {
            obj.GetComponent<FocusHandler>().enabled = enable;
            obj.GetComponent<MeshOutline>().enabled = enable;
            obj.GetComponent<Interactable>().enabled = enable;
            obj.GetComponent<ObjectManipulator>().enabled = enable;
        }
    }

    public void ToStartCoordinateBase()
    {
        StartCoroutine(GetComponent<Lerping>().LerpFunctionPosition(multimeterBase.transform.position, _startPositionMultimeterBase, 0.2f));
    }
}