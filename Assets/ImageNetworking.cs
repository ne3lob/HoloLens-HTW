using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class ImageNetworking : MonoBehaviourPunCallbacks
{
    private GameObject prefab;
    public GameObject parent;

    public GameObject target;

    // Start is called before the first frame update


    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.LogWarning($"Failed to connect: {cause}");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        // Failed to connect to random
        Debug.Log(message);

        // Create room
        PhotonNetwork.CreateRoom("My First Room");
    }

    public override void OnJoinedRoom()
    {
        Debug.Log($"{PhotonNetwork.CurrentRoom.Name} joined!");
        prefab = PhotonNetwork.Instantiate("image", target.transform.position, Quaternion.identity, 0);
        prefab.transform.parent = parent.transform;
    }
}