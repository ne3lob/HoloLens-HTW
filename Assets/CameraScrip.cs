using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScrip : MonoBehaviour
{
    private Camera myCamera;
    public RenderTexture myTexture;

    // Start is called before the first frame update
    void Start()
    {
        myCamera = gameObject.GetComponent<Camera>();
    }


    public void SwitchingCullingMaskOn()
    {
        // myCamera.cullingMask |= (1 << 8);
        //myCamera.targetTexture = null;
        StartCoroutine(UploadPNG());
    }

    public void SwitchingCullingMaskOff()
    {
        // myCamera.cullingMask &= ~(1 << 8);
        //myCamera.targetTexture = myTexture;
    }

    IEnumerator UploadPNG()
    {
        Debug.Log("Yes");
        myCamera.targetTexture = myTexture;
        Debug.Log("Yes1");
        yield return new WaitForEndOfFrame();
        Debug.Log(("no"));
        myCamera.targetTexture = null;
    }
}