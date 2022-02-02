using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodySleepState : MonoBehaviour
{
    private Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.Sleep();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
