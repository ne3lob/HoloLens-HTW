using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorKiste : MonoBehaviour
{
    private Vector3 targetRotationOpen;
    private Vector3 targetRotationClose;
    private bool open;
    [SerializeField] private List<GameObject> FusesToolTip;
    [SerializeField] private List<GameObject> FisToolTip;

    //Door Handel Animator
    [SerializeField] private Animator _doorHandleAnimator;
    private static readonly int OpenDoorHandle = Animator.StringToHash("OpenDoorHandle");
    private static readonly int CloseDoorHandle = Animator.StringToHash("CloseDoorHandle");

    // Start is called before the first frame update
    private void Start()
    {
        var rotation = transform.localRotation;
        
        //Rotation Angle
        targetRotationOpen = new Vector3(0, -48, 0);
        targetRotationClose = new Vector3(0, -180, 0);
        open = false;
    }

    IEnumerator LerpFunction(Quaternion endValue, float duration)
    {
        float time = 0;
        Quaternion startValue = transform.localRotation;

        while (time < duration)
        {
            transform.localRotation = Quaternion.Lerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        transform.localRotation = endValue;
    }

    public void OpenDoor()
    {
        open = !open;
        StartCoroutine(!open
            ? LerpFunction(Quaternion.Euler(targetRotationOpen), 1)
            : LerpFunction(Quaternion.Euler(targetRotationClose), 1));

        foreach (var fuse in FusesToolTip)
        {
            fuse.SetActive(!open);
            
        }

        foreach (var fi in FisToolTip)
        {
            fi.SetActive(!open);
        }
    }

    public void SmallHandleDoorOpen()
    {
        _doorHandleAnimator.SetTrigger("OpenDoorHandle");
        Debug.Log("Open Door");
    }
    public void SmallHandleDoorClose()
    {
        _doorHandleAnimator.SetTrigger("CloseDoorHandle");
        Debug.Log("Close Door");
    }
}