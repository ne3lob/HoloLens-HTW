using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorKiste : MonoBehaviour
{
    private Vector3 targetRotationOpen;
    private Vector3 targetRotationClose;
    private bool open;

    // Start is called before the first frame update
    void Start()
    {
        var rotation = transform.rotation;
        targetRotationOpen = new Vector3(-90, 0, 50);
        targetRotationClose = new Vector3(-90, 0, -90);
        open = false;
    }

    IEnumerator LerpFunction(Quaternion endValue, float duration)
    {
        float time = 0;
        Quaternion startValue = transform.rotation;

        while (time < duration)
        {
            transform.rotation = Quaternion.Lerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        transform.rotation = endValue;
    }

    public void OpenDoor()
    {
        open = !open;
        StartCoroutine(!open
            ? LerpFunction(Quaternion.Euler(targetRotationOpen), 1)
            : LerpFunction(Quaternion.Euler(targetRotationClose), 1));
    }
}