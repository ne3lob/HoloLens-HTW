using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerSwitch : MonoBehaviour
{
    private Vector3 targetServerSwitchRotationOn;
    private Vector3 targetServerSwitchRotationOff;

    private bool switchServerIsOn;

    // Start is called before the first frame update
    void Start()
    {
        targetServerSwitchRotationOn = new Vector3(-104, -90, 90);
        targetServerSwitchRotationOff = new Vector3(-90, -90, 90);
    }

    public void ServerSwitchOnOff()
    {
        switchServerIsOn = !switchServerIsOn;
        StartCoroutine(switchServerIsOn
            ? GetComponent<Lerping>().LerpFunction(Quaternion.Euler( targetServerSwitchRotationOn), 0.1f)
            : GetComponent<Lerping>().LerpFunction(Quaternion.Euler(targetServerSwitchRotationOff ), 0.1f));    }


    }
