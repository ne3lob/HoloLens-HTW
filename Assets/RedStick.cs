using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedStick : MonoBehaviour
{
    private Vector3 _startPositionRedStick;

    private int _fistConnectionWithRedStick;

    // Start is called before the first frame update
    public void SaveCoordinateRedStick()
    {
        if (_fistConnectionWithRedStick < 1)
        {
            _startPositionRedStick = transform.position;
            _fistConnectionWithRedStick++;
        }
    }


    public void ToStartCoordinateRedStick()
    {
        StartCoroutine(GetComponent<Lerping>().LerpFunctionPosition(transform.position, _startPositionRedStick, 0.2f));
    }
}