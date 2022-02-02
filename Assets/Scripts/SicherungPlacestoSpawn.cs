using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SicherungPlacestoSpawn : MonoBehaviour
{
    public SicherungSlot2 _scriptSicherungSlot2;
    public SicherungSlot4 _scriptSicherungSlot4;
    [SerializeField] private Transform _transformSicherungFloor;


    public void CheckSecondSlot()
    {
        if (_scriptSicherungSlot2.insideSlot2)
        {
            _scriptSicherungSlot2.colGameObjectSlot2.transform.position = new Vector3(_scriptSicherungSlot2._transformSicherungSlot2.position.x, _scriptSicherungSlot2._transformSicherungSlot2.position.y, _scriptSicherungSlot2._transformSicherungSlot2.position.z);
        }
        // else if (!_scriptSicherungSlot2.insideSlot2)
        // {
        //     StartCoroutine(GetComponent<Lerping>().LerpFunctionPosition(_scriptSicherungSlot2.colGameObjectSlot2.transform.position, _transformSicherungFloor.transform.position, 0.2f));
        //     Debug.Log("едет");
        // }
    }

    public void CheckFourthSlot()
    {
        if (_scriptSicherungSlot4.insideSlot4)
        {
            _scriptSicherungSlot4.colGameObjectSlot4.transform.position = new Vector3(_scriptSicherungSlot4._transformSicherungSlot4.position.x, _scriptSicherungSlot4._transformSicherungSlot4.position.y, _scriptSicherungSlot4._transformSicherungSlot4.position.z);
        }
    }
}