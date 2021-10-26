using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Server : MonoBehaviour
{
    [SerializeField] private GameObject labelServerOff;
    [SerializeField] private GameObject labelServerOn;


    public bool serverIsEnable;

    public void ServerSwitching()
    {
        switch (serverIsEnable)
        {
            case false:

                StartCoroutine(GetComponent<Switcher>().LabelCall(labelServerOn, 0.5f));
                serverIsEnable = true;
                break;
            case true:

                StartCoroutine(GetComponent<Switcher>().LabelCall(labelServerOff, 0.5f));
                serverIsEnable = false;
                break;
        }
        
    }
}