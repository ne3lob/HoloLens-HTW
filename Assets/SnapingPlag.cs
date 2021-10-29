using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapingPlag : MonoBehaviour
{
    private bool _plugIsRotated;
    private bool _plugIsConnectedToSocket;

    private Vector3 startPlugRotation;
    private Vector3 targetPlugRotation;

    // Start is called before the first frame update
    void Start()
    {
        startPlugRotation = new Vector3(-90, -90, 10);
        targetPlugRotation = new Vector3(0, 0, 180);
    }

    // Update is called once per frame
    public void PlugRotationToTarger()
    {
        StartCoroutine(GetComponent<Lerping>().LerpFunction(Quaternion.Euler(targetPlugRotation), 1));
    }
    public void PlugRotationToStart()
    {
        StartCoroutine(GetComponent<Lerping>().LerpFunction(Quaternion.Euler(startPlugRotation), 1));
    }
    
    
}