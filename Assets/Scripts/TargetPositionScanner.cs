using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPositionScanner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    [SerializeField] private GameObject LeftPlane;
    [SerializeField] private GameObject LeftPlaneLable;
    [SerializeField] private GameObject targetNext;

    [SerializeField] private GameObject BottomPlane;
    [SerializeField] private GameObject BottomPlaneLable;


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "PlaneLeft")
        {
            Debug.Log("collision");
            LeftPlane.transform.position = targetNext.transform.position;
            LeftPlane.GetComponent<MeshRenderer>().enabled = false;
            LeftPlaneLable.SetActive(false);
            BottomPlane.SetActive(true);
        }

        else if (col.gameObject.tag == "PlaneBottom")
        {
            Debug.Log("collision");
            BottomPlane.transform.position = gameObject.transform.position;
            BottomPlane.GetComponent<MeshRenderer>().enabled = false;
            BottomPlaneLable.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}