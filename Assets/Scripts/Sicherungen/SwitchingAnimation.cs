using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchingAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 _targetRotationSwitcherOff;
    private Vector3 _targetRotationSwitcherOn;

    private FuseFirst _fF;

    private FuseSecond _fS;
    
    private FuseThird _fT;

    //private FuseThird _fT;
    private ResidualCurrentDevice _rD;

    void Awake()
    {
        _fF = GameObject.Find("BaseSicherungFirst").GetComponent<FuseFirst>();
        _fS = GameObject.Find("BaseSicherungSecond").GetComponent<FuseSecond>();
        _fT = GameObject.Find("BaseSicherungThird").GetComponent<FuseThird>();
        _rD = GameObject.Find("BaseFI").GetComponent<ResidualCurrentDevice>();
    }

    void Start()
    {
        // _fT = GameObject.Find("BaseSicherungThird").GetComponent<FuseThird>();


        _targetRotationSwitcherOff = new Vector3(0, 0, -5);
        _targetRotationSwitcherOn = new Vector3(0, 0, -98);
    }

    //TODO coroutine for Lerping
    private void LerpingSwitcher(bool fuseBool)
    {
        StartCoroutine(fuseBool ? GetComponent<Lerping>().LerpFunctionRotation(Quaternion.Euler(_targetRotationSwitcherOn), 0.1f) : GetComponent<Lerping>().LerpFunctionRotation(Quaternion.Euler(_targetRotationSwitcherOff), 0.1f));
    }

    public void TurnSwitcherFirstFuse()
    {
        LerpingSwitcher(_fF.fuseFirstIsEnable);
    }

    public void TurnSwitcherSecondFuse()
    {
        LerpingSwitcher(_fS.fuseSecondIsEnable);
    }

     public void TurnSwitcherThirdFuse()
     {
         LerpingSwitcher(_fT.fuseThirdIsEnable);
     }
    public void TurnSwitcherResidualCurrentDevice()
    {
        LerpingSwitcher(_rD.fiIsEnable);
    }
}