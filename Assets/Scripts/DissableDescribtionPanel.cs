using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissableDescribtionPanel : MonoBehaviour
{
    private static DissableDescribtionPanel _instance;

    private void Awake()
    {
        if (_instance == null)
            _instance = this;
    }

    public static void DelayedStart(GameObject target, float time)
    {
        _instance.StartCoroutine(DelayedStartCoroutine(target, time));
    }

    private static IEnumerator DelayedStartCoroutine(GameObject target, float time)
    {
        yield return new WaitForSeconds(time);
        if (target.activeInHierarchy) target.SetActive(false);
    }
}