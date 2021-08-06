using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class PlugIn : MonoBehaviour
{
    [SerializeField] private GameObject plug;

    [SerializeField] private GameObject plugTriggerPosition;
    private bool _electricity = true;
    private float distance_;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        distance_ = Vector3.Distance(plug.transform.position, plugTriggerPosition.transform.position);
        if (distance_ < 0.05f)
        {
            plug.transform.position = plugTriggerPosition.transform.position;
            plug.transform.rotation = plugTriggerPosition.transform.rotation;
        }
    }
}