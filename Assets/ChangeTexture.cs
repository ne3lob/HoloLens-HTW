using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class ChangeTexture : MonoBehaviourPun
{
    public Texture2D textureToSend;
    public byte[] N;

    private Texture2D receivedTexture;

    void Update()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            photonView.RPC("Send", RpcTarget.Others, textureToSend.EncodeToPNG());
        }
    }


    IEnumerator GetRenderTexturePixel(Texture2D tex)
    {
        Texture2D tempTex = new Texture2D(tex.width, tex.height);
        yield return new WaitForEndOfFrame();
        tempTex.ReadPixels(new Rect(0, 0, tex.width, tex.height), 0, 0);
        tempTex.Apply();
        N = tempTex.EncodeToPNG();
    }


    [PunRPC]
    void Send(byte[] receivedByte)
    {
        receivedTexture = new Texture2D(1, 1);
        receivedTexture.LoadImage(receivedByte);
        GetComponent<Renderer>().material.mainTexture = receivedTexture;
    }
}