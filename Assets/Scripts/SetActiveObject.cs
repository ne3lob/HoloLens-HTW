using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveObject : MonoBehaviour
{
    [Tooltip("RCD,Socket,Server,Plug,Fuses in the FuseBox,2Panel")] [SerializeField]
    private GameObject[] GameObjectsSetActive;

    public void SetActive()
    {
        foreach (var gameObject in GameObjectsSetActive)
        {
            gameObject.SetActive(true);
        }
    }
}