using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class FuseSlotsToSpawn : MonoBehaviour
{
    public FuseSlot1 _scriptFuseSlot1;
    public FuseSlot2 _scriptFuseSlot2;


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
        } //TODO floor
    }

    public void CheckAllSlots()
    {
        CheckSlot(_scriptFuseSlot1.insideSlot1, _scriptFuseSlot1.GameObjecIntSlot1, _scriptFuseSlot1._transformFuseSlot1);
        CheckSlot(_scriptFuseSlot2.insideSlot2, _scriptFuseSlot2.GameObjecIntSlot2, _scriptFuseSlot2._transformFuseSlot2);
    }
}