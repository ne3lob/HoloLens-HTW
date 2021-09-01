using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColor : MonoBehaviour
{
    private bool _activeSelected;
    [SerializeField] private List<GameObject> massbands;


    [SerializeField] private Material selectedMat;

    [SerializeField] private Material normalMat;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void ChangeColor()
    {
        _activeSelected = !_activeSelected;
        this.gameObject.GetComponent<Renderer>().material = !_activeSelected ? normalMat : selectedMat;
        if (!_activeSelected)
        {
            foreach (var massband in massbands)
            {
                massband.SetActive(false);
            }
        }
    }

    public void DisableFirst(GameObject first)
    {
        first.SetActive(_activeSelected);
    }
}