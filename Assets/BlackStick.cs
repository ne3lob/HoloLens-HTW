using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackStick : MonoBehaviour
{
    private Vector3 _startPositionBlackStick;

    private int _fistConnectionWithBlackStick;

    // Start is called before the first frame update
    public void SaveCoordinateBlackStick()
    {
        if (_fistConnectionWithBlackStick < 1)
        {
            _startPositionBlackStick = transform.position;
            _fistConnectionWithBlackStick++;
        }
    }


    public void ToStartCoordinateBlackStick()
    {
        StartCoroutine(GetComponent<Lerping>().LerpFunctionPosition(transform.position, _startPositionBlackStick, 0.2f));
    }
}