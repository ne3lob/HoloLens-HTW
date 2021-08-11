using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PullOfObjectsInKaste : MonoBehaviour
{
    // [SerializeField] private GameObject SicherungOne;
    // [SerializeField] private GameObject SicherungTwo;
    // [SerializeField] private GameObject SicherungThree;
    // [SerializeField] private GameObject SicherungOneStart;
    // [SerializeField] private GameObject SicherungTwoStart;
    // [SerializeField] private GameObject SicherungThreeStart;
    // [SerializeField] private GameObject SicherungOneTarget;
    // [SerializeField] private GameObject SicherungTwoTarget;
    // [SerializeField] private GameObject SicherungThreeTarget;
    [SerializeField] GameObject ToolTipNewOne;
    [SerializeField] GameObject ToolTipNewTwo;

    float distanceSicherungOne;
    float distanceSicherungTwo;
    float distanceSicherungThree;
    private bool inKiste = false;


    void Update()
    {
        // Distance(distanceSicherungOne, SicherungOne, SicherungOneStart, SicherungOneTarget);
        // Distance(distanceSicherungTwo, SicherungTwo, SicherungTwoStart, SicherungTwoTarget);
        //Distance(distanceSicherungThree, SicherungThree, SicherungThreeStart, SicherungThreeTarget);
    }

    void Distance(float distanceObj, GameObject obj, GameObject start, GameObject target)
    {
        distanceObj = Vector3.Distance(obj.transform.position, start.transform.position);
        if (distanceObj < 0.01f)
        {
            obj.transform.position = start.transform.position;
            obj.transform.rotation = start.transform.rotation;
        }

        else if (distanceObj > 0.03f)
        {
            obj.transform.position = target.transform.position;
            obj.transform.rotation = target.transform.rotation;
        }
    }

    public void ChangePosition(GameObject target)
    {
        if (inKiste == false)
        {
            gameObject.transform.position = target.transform.position;
            ToolTipNewOne.SetActive(true);
            ToolTipNewTwo.SetActive(true);
        }
    }

    public void ChangePositionBack(GameObject start)
    {
        if (inKiste)
        {
            gameObject.transform.position = start.transform.position;
            ToolTipNewOne.SetActive(false);
            ToolTipNewTwo.SetActive(false);
        }
    }
}