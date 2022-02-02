using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCloseWithDelay : MonoBehaviour
{
    public GameObject targetObject;
    public float sec = 1f;

    public void DisablePanel()
    {
        DissableDescribtionPanel.DelayedStart(targetObject, sec);
    }
}