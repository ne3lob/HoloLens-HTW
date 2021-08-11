using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenKiste : MonoBehaviour
{
    // [SerializeField] List<GameObject> toolTips;
    [SerializeField] GameObject Door_;
    [SerializeField] GameObject RotationObject;

    public float smooth = 1f;
    private Quaternion targetRotation;
    private bool open = false;
    [SerializeField] GameObject ToolTipOne;
    [SerializeField] GameObject ToolTipTwo;
    [SerializeField] GameObject ToolTipKiste;


    // Start is called before the first frame update
    void Start()
    {
        targetRotation = RotationObject.transform.rotation;
        // foreach (var tool in toolTips)
        // {
        //     tool.SetActive(false);
        // }
        ToolTipOne.SetActive(false);
        ToolTipTwo.SetActive(false);
        ToolTipKiste.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if (open == false)
        // {
        //     Door_.transform.rotation =
        //         Quaternion.Lerp(Door_.transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);
        //     open = true;
        // }
    }

    public void OpenDoor()
    {
        // Door_.transform.rotation =
        //            Quaternion.Lerp(Door_.transform.rotation, targetRotation, 50 * smooth * Time.deltaTime);
        Door_.SetActive(false);
        RotationObject.SetActive(true);
        ToolTipOne.SetActive(true);
        ToolTipTwo.SetActive(true);
        ToolTipKiste.SetActive(false);
    }

    public void CloseDoor()
    {
        Door_.SetActive(true);
        RotationObject.SetActive(false);
        ToolTipOne.SetActive(false);
        ToolTipKiste.SetActive(true);
        ToolTipTwo.SetActive(false);
    }
}