using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DisabledCollidersOnSicherungkastenObjects : MonoBehaviour
{
    public void TurnOnSicherungkastenCollider()
    {
        GameObject.Find("CaseSicherungkaste").GetComponent<MeshCollider>().enabled = true;
        GameObject.Find("DoorSicherungkaste").GetComponent<BoxCollider>().enabled = true;
        GameObject.Find("BackgroundCaseSicherungkaste").GetComponent<MeshCollider>().enabled = true;
    }

    public void TurnOffSicherungkastenCollider()
    {
        GameObject.Find("CaseSicherungkaste").GetComponent<MeshCollider>().enabled = false;
        GameObject.Find("DoorSicherungkaste").GetComponent<BoxCollider>().enabled = false;
        GameObject.Find("BackgroundCaseSicherungkaste").GetComponent<MeshCollider>().enabled = false;
    }
}