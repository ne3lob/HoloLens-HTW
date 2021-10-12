using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorKiste : MonoBehaviour
{
    private Vector3 targetRotationOpen;
    private Vector3 targetRotationClose;
    private bool open;
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
        StartCoroutine(open
            ? LerpFunction(Quaternion.Euler(targetRotationOpen), 1)
            : LerpFunction(Quaternion.Euler(targetRotationClose), 1));
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
        _doorIsOpen = !_doorIsOpen;
        if (!_doorIsOpen)
        {
            Debug.Log("play");

            _audio.Play();
        }
    }
}