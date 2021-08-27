using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class DistanceMassband : MonoBehaviour
{
    private float _differenceFirstSecond;
    private float _differenceSeconfThird;
    public float _distanceInMetre;
    [SerializeField] public ToolTip  metreToolFirst;
    [SerializeField] public ToolTip  metreToolSecond;


    [SerializeField] private GameObject _firstPoint;
    [SerializeField] private GameObject _secondPoint;
    [SerializeField] private GameObject _thirdPoint;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _distanceInMetre = DifferenceFirstAndSecondPoints() + DifferenceSecondAndTherdPoints();
        ToolTipText();
        
    }

    float DifferenceFirstAndSecondPoints()
    {
        Vector3 g1 = new Vector3(0, _firstPoint.transform.position.y, 0);
        Vector3 g2 = new Vector3(0, _secondPoint.transform.position.y, 0);

        _differenceFirstSecond = Vector3.Distance(g1, g2);
        return _differenceFirstSecond;
        
        //_distanceInMetreY = _differenceFirstSecond;
      
    }
    float DifferenceSecondAndTherdPoints()
    {
        Vector3 g3 = new Vector3(_secondPoint.transform.position.x, 0, 0);
        Vector3 g4 = new Vector3(_thirdPoint.transform.position.x, 0, 0);

        _differenceSeconfThird = Vector3.Distance(g3, g4);
        return _differenceSeconfThird;
       // _distanceInMetreX = _differenceSeconfThird;
        
    }
    

    void ToolTipText()
    {
        metreToolFirst.ToolTipText = _distanceInMetre.ToString("F1") + "m";
        metreToolSecond.ToolTipText = _distanceInMetre.ToString("F1") + "m";
    }
    
}