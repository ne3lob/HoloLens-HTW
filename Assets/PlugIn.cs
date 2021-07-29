using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlugIn : MonoBehaviour
{
    [SerializeField] private GameObject plug;

    [SerializeField] private GameObject plugTriggerPosition;
    private bool _electricity=true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        
        plug.transform.position = plugTriggerPosition.transform.position;
        if (_electricity)
        {
            Debug.Log("true");
        }
        else
        {
            Debug.Log("no");
        }
    }
}