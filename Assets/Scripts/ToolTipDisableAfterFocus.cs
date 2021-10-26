using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;
using UnityEngine.Serialization;

public class ToolTipDisableAfterFocus : MonoBehaviour
{
    private int _focusCount;

    // Update is called once per frame
    public void ToolTipDisable()
    {
        _focusCount++;
        if (_focusCount > 5)
        {
            GetComponent<ToolTipSpawner>().enabled = false;
        }
    }
}