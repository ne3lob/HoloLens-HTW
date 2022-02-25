using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketActivation : MonoBehaviour
{
    void Start()
    {
       gameObject.SetActive(false);
    }

    public void BasketActivator()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}