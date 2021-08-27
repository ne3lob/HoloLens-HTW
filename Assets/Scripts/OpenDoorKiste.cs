using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorKiste : MonoBehaviour
{
    private Vector3 targetRotationOpen;
    private Vector3 targetRotationClose;
    private bool open;
    [SerializeField] private List<GameObject> Tooltips;

    // Start is called before the first frame update
    private void Start()
    {
        var rotation = transform.localRotation;
        targetRotationOpen = new Vector3(0, 45, 0);
        targetRotationClose = new Vector3(0, -90, 0);
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
        foreach (var obj in Tooltips)
        {
            obj.SetActive(!open);
        }
        
    }
}