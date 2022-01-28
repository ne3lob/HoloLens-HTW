using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SicherungPlacestoSpawn : MonoBehaviour
{
    public SicherungSlot2 _scriptSicherungSlot2;
    [SerializeField] private Transform _transformSicherungFloor;

    void Start()
    {
        //_scriptSicherungSlot2 = GetComponent<SicherungSlot2>();
    }


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
}