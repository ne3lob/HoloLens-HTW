using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multimetr : MonoBehaviour
{
    [SerializeField] public GameObject FIToolTipBox;
    [SerializeField] public GameObject SocketToolTipBox;
    [SerializeField] public GameObject FItoolTipBox;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FI")
        {
            FIToolTipBox.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "FI")
        {
            FIToolTipBox.SetActive(false);
        }
    }
}