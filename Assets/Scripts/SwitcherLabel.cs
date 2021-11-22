using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherLabel : MonoBehaviour
{
    public IEnumerator LabelCall(GameObject label, float seconds)
    {
        label.SetActive(true);

        yield return new WaitForSeconds(seconds);

        label.SetActive(false);
    }
}