using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class SocketIn : MonoBehaviour
{
    private PlugInServer _plugInServerScript;

    private GameObject _pluginInServerObject;

    // Start is called before the first frame update
    void Start()
    {
        _pluginInServerObject = GameObject.Find("Plug");
        _plugInServerScript = _pluginInServerObject.GetComponent<PlugInServer>();
    }


    // public void SelectedSocket()
    // {
    //     if (_plugInServerScript._isSelectedPlug)
    //     {
    //         _plugInServerScript.MovePlug();
    //     }
    //     
    // }
}