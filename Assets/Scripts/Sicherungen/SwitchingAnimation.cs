using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SwitchingAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 _targetRotationSwitcherOff;
    private Vector3 _targetRotationSwitcherOn;

    private Fuse _fuse;


    //private FuseThird _fT;
    private ResidualCurrentDevice _rD;


    void Start()
    {
        _fuse = gameObject.GetComponentInParent<Fuse>();
        _rD = gameObject.GetComponentInParent<ResidualCurrentDevice>();


        _targetRotationSwitcherOff = new Vector3(0, -19, 0);
        _targetRotationSwitcherOn = new Vector3(0, 90, 0);
    }


    private void LerpingSwitcher(bool fuseBool)
    {
        StartCoroutine(fuseBool ? GetComponent<Lerping>().LerpFunctionRotation(Quaternion.Euler(_targetRotationSwitcherOn), 0.1f) : GetComponent<Lerping>().LerpFunctionRotation(Quaternion.Euler(_targetRotationSwitcherOff), 0.1f));
    }

    public void TurnSwitcherFuse()
    {
        LerpingSwitcher(_fuse.fuseIsEnable);
    }

    public void TurnSwitcherResidualCurrentDevice()
    {
        LerpingSwitcher(_rD.fiIsEnable);
    }
}