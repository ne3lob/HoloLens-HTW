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
        StartCoroutine(UploadPNG());
    }

    IEnumerator UploadPNG()
    {
        myCamera.targetTexture = myTexture;
        yield return new WaitForEndOfFrame();
        myCamera.targetTexture = null;
    }
}