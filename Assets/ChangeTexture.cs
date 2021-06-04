using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class ChangeTexture : MonoBehaviourPunCallbacks, IPunObservable
{
    public RawImage image;

    private Texture2D toTexture2D(Texture rTex)
    {
        Texture2D dest = new Texture2D(rTex.width, rTex.height, TextureFormat.RGBA32, false);
        dest.Apply(false);
        Graphics.CopyTexture(rTex, dest);
        return dest;
    }

    private byte[] rawData;
    private Texture2D tex;

    void Update()
    {
    }


    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            tex = toTexture2D(image.texture);
            rawData = tex.EncodeToPNG();
            stream.SendNext(rawData);
            Debug.Log(rawData);
        }
    }
}