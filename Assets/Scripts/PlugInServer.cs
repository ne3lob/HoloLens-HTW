using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlugInServer : MonoBehaviour
{
    [FormerlySerializedAs("SelectedGameObjects")] [SerializeField]
    private List<GameObject> selectedGameObjects;

    //[SerializeField] private GameObject plug;

    [SerializeField] private Material selectedMaterial;
    public bool _isSelectedPlug;

    private GameObject _targetSelectedObject;

    private SelectedObject _selectedObjectListScript;
    private GameObject _manager;

    private Vector3 targetRotationPlug;
    private Vector3 targetPositionPlug;

    void Start()
    {
        _isSelectedPlug = false;
         _manager = GameObject.Find("_MANAGER_");
          _selectedObjectListScript = _manager.GetComponent<SelectedObject>();
        targetRotationPlug = new Vector3(0, -103, 0);
        targetPositionPlug = new Vector3(5.573f, 0.71f, 3.913f);
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

    IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = transform.localPosition;

        while (time < duration)
        {
            transform.localPosition = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        transform.localPosition = targetPosition;
    }


    public void SelectObjectFunction()
    {
        //TODO check the active number 
        // if(_selectedObjectList.SelectedObjectList.)
        // _selectedObjectList.SelectedObjectList.Clear();
        // foreach (var obj in selectedGameObjects)
        // {
        //     obj.GetComponent<MeshRenderer>().material = selectedMaterial;
        // }

        _isSelectedPlug = !_isSelectedPlug;

        _selectedObjectListScript.selectedObjectList.Add(this.gameObject);
    }

    public void MovePlug()
    {
        if (!_isSelectedPlug) return;
        StartCoroutine(LerpPosition(targetPositionPlug, 2));
        StartCoroutine(LerpFunction(Quaternion.Euler(targetRotationPlug), 2));
    }
}