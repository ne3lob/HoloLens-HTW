using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallChaser : MonoBehaviour
{
    [SerializeField] private GameObject targetRotationReference;
    [SerializeField] private GameObject toolBoxGameObject;

    private Quaternion startWallChaserRotation;
    private Quaternion targetWallChaserRotation;

    private Vector3 startWallChaserPosition;
    private Vector3 targetWallChaserPosition;

    // Start is called before the first frame update
    void Start()
    {
        startWallChaserRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private int _fistConnectionWitchWallChaser;

    public void SaveStartPositionWallChaser()
    {
        if (_fistConnectionWitchWallChaser < 1)
        {
            startWallChaserPosition = transform.position;
            _fistConnectionWitchWallChaser++;
        }
    }

    public void WallChaserRotationToTarger()
    {
        if (transform.rotation != targetWallChaserRotation)
        {
            targetWallChaserRotation = targetRotationReference.transform.rotation;

            StartCoroutine(GetComponent<Lerping>().LerpFunctionRotation(targetWallChaserRotation, 0.5f));
            transform.rotation = targetWallChaserRotation;
        }
    }

    private float _distancetoWallChaser;

    public void WallChaserToStart()
    {
        CheckDistanceToWallChaser(gameObject, toolBoxGameObject);
        Debug.Log(_distancetoWallChaser);
        if (_distancetoWallChaser > 1f)
        {
            StartCoroutine(GetComponent<Lerping>().LerpFunctionRotation(Quaternion.Euler(startWallChaserRotation.eulerAngles), 0.5f));
            StartCoroutine(GetComponent<Lerping>().LerpFunctionPosition(transform.position, startWallChaserPosition, 0.2f));
        }
    }

    private void CheckDistanceToWallChaser(GameObject startPointObject, GameObject targetPointObject)
    {
        _distancetoWallChaser = Vector3.Distance(startPointObject.transform.position, targetPointObject.transform.position);
    }
}