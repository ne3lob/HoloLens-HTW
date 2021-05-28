using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketActivation : MonoBehaviour
{
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    public void BasketActivator()
    {
        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }
}