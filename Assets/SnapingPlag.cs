using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapingPlag : MonoBehaviour
{
    private bool _plugIsRotated;
    private bool _plugIsConnectedToSocket;
    [SerializeField] private GameObject socketGameObject;
    [SerializeField] private GameObject plugGameObject;

    private Quaternion startPlugRotation;
    private Quaternion targetPlugRotation;
    private Quaternion randomPlugRotation;

    private Vector3 startPlugPosition;
    private Vector3 targetPlugPosition;

    private AudioSource audioPlug;
    // Start is called before the first frame update
    void Start()
    {
        startPlugRotation = plugGameObject.transform.rotation;
        targetPlugRotation = Quaternion.Euler(-90, 0, 90);

        startPlugPosition = plugGameObject.transform.position;
        targetPlugPosition = socketGameObject.transform.position;
        audioPlug = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlugRotationToTarger()
    {
        StartCoroutine(GetComponent<Lerping>().LerpFunctionRotation(targetPlugRotation, 0.5f));
        plugGameObject.transform.rotation = targetPlugRotation;
    }

    public void PlugRotationToStart()
    {
        randomPlugRotation = Quaternion.Euler(startPlugRotation.x, Random.Range(30, 160),
            Random.Range(-30, -160));
        CheckDistance(gameObject, socketGameObject);
        if (_distance > 0.12f)
        {
            StartCoroutine(GetComponent<Lerping>().LerpFunctionRotation(Quaternion.Euler(randomPlugRotation.eulerAngles), 0.5f));
        }
        else if (_distance < 0.12)
        {
            audioPlug.Play();
        }
    }

    private float _distance;

    private void CheckDistance(GameObject startPointObject, GameObject targetPointObject)
    {
        _distance = Vector3.Distance(startPointObject.transform.position, targetPointObject.transform.position);


        StartCoroutine(_distance < 0.12f ? GetComponent<Lerping>().LerpFunctionPosition(plugGameObject.transform.position, targetPlugPosition, 0.2f) : GetComponent<Lerping>().LerpFunctionPosition(plugGameObject.transform.position, startPlugPosition, 0.2f));
    }
}