using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageAppearance : MonoBehaviour
{
    private int startHeight = 0;
    private int endWidth;

    private void Start()
    {
        gameObject.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, startHeight);
        imageOverlay.GetComponent<RectTransform>()
            .SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, startHeight);
    }

    public bool firstExercize = true;

    public void ChangedBoolExsercize()
    {
        firstExercize = false;
    }
   

    public void ImageScalingUp()
    {
        if (firstExercize)
        {
            StartCoroutine(ScaleOverTime(1f, 0f, 1280f));
        }
    }

    public void ImageScalingDown()
    {
        StartCoroutine(ScaleOverTime(1f, 1280f, 0f));
    }


    public void ImageToStartScale()
    {
        gameObject.GetComponent<RectTransform>()
            .SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, startHeight);
    }

    [SerializeField] private GameObject imageOverlay;

    IEnumerator ScaleOverTime(float time, float startPosition, float endPosition)
    {
        float currentTime = 0.0f;

        do
        {
            gameObject.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,
                Mathf.Lerp(startPosition, endPosition, currentTime / time));
            imageOverlay.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,
                Mathf.Lerp(startPosition, endPosition, currentTime / time));

            currentTime += Time.deltaTime;
            yield return null;
        } while (currentTime <= time);
    }
}