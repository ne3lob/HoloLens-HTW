using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class FuseSlotsToSpawn : MonoBehaviour
{
    public FuseSlot2 _scriptFuseSlot2;
    private bool insideSlot2;

    // public SicherungSlot4 _scriptSicherungSlot4;
    private Transform _transformSicherungFloor;

    void Start()
    {
        _transformSicherungFloor = GameObject.FindWithTag("Floor").transform;
    }

    private void CheckSlot(bool isInsideSlot, GameObject gameObjectInSlot, Transform transformFuse)
    {
        if (isInsideSlot)
        {
            gameObjectInSlot.transform.position = new Vector3(transformFuse.position.x, transformFuse.position.y, transformFuse.position.z);
            Debug.Log("Been");
        } //TODO floor
    }

    public void CheckSlot2()
    {
        CheckSlot(_scriptFuseSlot2.insideSlot2, _scriptFuseSlot2.GameObjecIntSlot2, _scriptFuseSlot2._transformFuseSlot2);
    }
}