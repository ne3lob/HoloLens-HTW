using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollider : MonoBehaviour
{
    [SerializeField] private GameObject colliderAnimation;
    [SerializeField] private GameObject _handMenu;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Point")
        {
            Debug.Log("collision");
            colliderAnimation.GetComponent<Animator>().enabled = false;
            _handMenu.GetComponent<HandMenuLogic>().HandMenuBoolToFalse();
        }
    }
}