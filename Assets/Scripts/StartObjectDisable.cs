using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class StartObjectDisable : MonoBehaviour
{
    [FormerlySerializedAs("DisableObjectsInScene")] [SerializeField]
    private List<GameObject> disableObjectsInScene;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var obj in disableObjectsInScene)
        {
            obj.SetActive(false);
        }
    }
}