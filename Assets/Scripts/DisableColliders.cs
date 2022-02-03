using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DisableColliders : MonoBehaviour
{
    [SerializeField] private GameObject CaseFuseBox;
    [SerializeField] private GameObject DoorFuseBox;
    [SerializeField] private GameObject BackgroundFuseBox;

    public void TurnOnCollider()
    {
        CaseFuseBox.GetComponent<MeshCollider>().enabled = true;
        DoorFuseBox.GetComponent<BoxCollider>().enabled = true;
        BackgroundFuseBox.GetComponent<BoxCollider>().enabled = true;
    }

    public void TurnOffCollider()
    {
        CaseFuseBox.GetComponent<MeshCollider>().enabled = false;
        DoorFuseBox.GetComponent<BoxCollider>().enabled = false;
        BackgroundFuseBox.GetComponent<BoxCollider>().enabled = false;
    }
}