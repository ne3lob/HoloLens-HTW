using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObjectInAwake : MonoBehaviour
{
    // Start is called before the first frame update

    void Awake()
    {
        gameObject.SetActive(true);
    }

    void Start()
    {
        gameObject.SetActive(false);
    }
}