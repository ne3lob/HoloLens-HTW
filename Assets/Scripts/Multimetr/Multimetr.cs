using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multimetr : MonoBehaviour
{
    [SerializeField] public GameObject FIToolTipBox;
    [SerializeField] public GameObject SocketToolTipBox;
    [SerializeField] public GameObject Fuse_1_ToolTipBox;
    [SerializeField] public GameObject Fuse_2_ToolTipBox;
    
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
        else if (other.gameObject.tag == "Socket")
        {
            SocketToolTipBox.SetActive(true);
        }
        else  if (other.gameObject.tag == "Fuse")
        {
            Fuse_1_ToolTipBox.SetActive(true);
        }
        else if (other.gameObject.tag == "Fuse_2")
        {
            Fuse_2_ToolTipBox.SetActive(true);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "FI")
        {
            FIToolTipBox.SetActive(false);
        }
       else if (other.gameObject.tag == "Socket")
        {
            SocketToolTipBox.SetActive(false);
        }
        else   if (other.gameObject.tag == "Fuse_1")
        {
            Fuse_1_ToolTipBox.SetActive(false);
        }
       else  if (other.gameObject.tag == "Fuse_2")
        {
            Fuse_2_ToolTipBox.SetActive(false);
        }
    }
}