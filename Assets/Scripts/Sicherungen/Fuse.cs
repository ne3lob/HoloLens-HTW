using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Fuse : MonoBehaviour
{
    [SerializeField] private int Ampere;
    [SerializeField] private GameObject labelFuseOff;
    [SerializeField] private GameObject labelFuseOn;
    [SerializeField] private GameObject multimetrText;


    public bool fuseIsEnable = true;
    private ResidualCurrentDevice _residualCurrentDeviceScript;

    private void Start()
    {
        _residualCurrentDeviceScript = GetComponent<ResidualCurrentDevice>();
    }

    public void FuseSwitching()
    {
        switch (fuseIsEnable)
        {
            case false:

                StartCoroutine(GetComponent<SwitcherLabel>().LabelCall(labelFuseOn, 0.5f));
                fuseIsEnable = true;
                break;
            case true:

                StartCoroutine(GetComponent<SwitcherLabel>().LabelCall(labelFuseOff, 0.5f));
                fuseIsEnable = false;
                break;
        }
    }

    private bool isCollidedWithRedStick = false;
    private bool isCollidedWithBlackStick = false;

    void OnCollisionEnter(Collision collision)
    {
        FuseSlot script = collision.collider.GetComponent<FuseSlot>();
        if (script != null && collision.gameObject.CompareTag("FuseSlot") && script.insideSlot == false)
        {
            script.insideSlot = true;
            script.GameObjecIntSlot = this.gameObject;
            Debug.Log("collide (name) : " + collision.collider.gameObject.name);
        }
        else if (collision.gameObject.CompareTag("RedStick"))
        {
            isCollidedWithRedStick = true;
        }
        else if (collision.gameObject.CompareTag("BlackStick"))
        {
            isCollidedWithBlackStick = true;
        }

        if (isCollidedWithRedStick && isCollidedWithBlackStick)
            multimetrText.SetActive(true);
    }

    void OnCollisionExit(Collision collision)
    {
        FuseSlot script = collision.collider.GetComponent<FuseSlot>();
        if (script != null && collision.gameObject.CompareTag("FuseSlot") && script.insideSlot)
        {
            script.insideSlot = false;
        }
        else if (collision.gameObject.CompareTag("RedStick"))
        {
            isCollidedWithRedStick = false;
        }
        else if (collision.gameObject.CompareTag("BlackStick"))
        {
            isCollidedWithBlackStick = false;
        }

        if (!isCollidedWithRedStick && !isCollidedWithBlackStick)
            multimetrText.SetActive(false);
    }
}