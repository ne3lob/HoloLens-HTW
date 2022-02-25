using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandscannerScript : MonoBehaviour
{
    [SerializeField] private GameObject abweigdoseGameObject;
    [SerializeField] private GameObject wandscannerGameObject;
    [SerializeField] private GameObject werkzeugkisteGameObject;


    private Quaternion startWandscannerRotation;
    private Quaternion targetWandscannerRotation;

    private Vector3 startWandScannerPosition;
    private Vector3 targetWandScannerPosition;

    // Start is called before the first frame update
    void Start()
    {
        startWandscannerRotation = wandscannerGameObject.transform.rotation;
        startWandScannerPosition = wandscannerGameObject.transform.position;
    }

    public void WandscannerRotationToTarger()
    {
        if (wandscannerGameObject.transform.rotation != targetWandscannerRotation)
        {
            targetWandscannerRotation = abweigdoseGameObject.transform.rotation;

            StartCoroutine(GetComponent<Lerping>().LerpFunctionRotation(targetWandscannerRotation, 0.5f));
            wandscannerGameObject.transform.rotation = targetWandscannerRotation;
        }
    }

    private int _fistConnectionWitchWandscanner;

    public void SaveStartPositionWandscanner()
    {
        if (_fistConnectionWitchWandscanner < 1)
        {
            startWandScannerPosition = wandscannerGameObject.transform.position;
            _fistConnectionWitchWandscanner++;
        }
    }

    private float _distancetoWandscanner;

    public void WandscannerToStart()
    {
        CheckDistanceToWandscanner(gameObject, werkzeugkisteGameObject);
        if (_distancetoWandscanner < 1f)
        {
            StartCoroutine(GetComponent<Lerping>().LerpFunctionRotation(Quaternion.Euler(startWandscannerRotation.eulerAngles), 0.5f));
            StartCoroutine(GetComponent<Lerping>().LerpFunctionPosition(wandscannerGameObject.transform.position, startWandScannerPosition, 0.2f));
        }
    }


    private void CheckDistanceToWandscanner(GameObject startPointObject, GameObject targetPointObject)
    {
        _distancetoWandscanner = Vector3.Distance(startPointObject.transform.position, targetPointObject.transform.position);
    }
}