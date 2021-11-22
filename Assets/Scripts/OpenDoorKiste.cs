using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoorKiste : MonoBehaviour
{
    private Vector3 targetRotationOpen;
    private Vector3 targetRotationClose;
    private bool isPpenDoor;
    private AudioSource _audio;


    private bool _doorIsOpen;


    //Door Handel Animator
    [SerializeField] private Animator _doorHandleAnimator;


    // Start is called before the first frame update
    private void Start()
    {
        _audio = GetComponent<AudioSource>();
        //Rotation Angle
        targetRotationOpen = new Vector3(0, -48, 0);
        targetRotationClose = new Vector3(0, -180, 0);
    }


    public void OpenDoor()
    {
        _doorIsOpen = !_doorIsOpen;
        StartCoroutine(_doorIsOpen
            ? GetComponent<Lerping>().LerpFunctionRotation(Quaternion.Euler(targetRotationOpen), 1)
            : GetComponent<Lerping>().LerpFunctionRotation(Quaternion.Euler(targetRotationClose), 1));
    }

    public void SmallHandleDoorOpen()
    {
        _doorHandleAnimator.SetTrigger("OpenDoorHandle");
    }

    public void SmallHandleDoorClose()
    {
        _doorHandleAnimator.SetTrigger("CloseDoorHandle");
    }

    public void AudioDoor()
    {
        if (!_doorIsOpen)
        {
            _audio.Play();
        }
    }
}