using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace TextureSendReceive
{
    [RequireComponent(typeof(Camera), typeof(TextureSender))]
    public class CameraSender : MonoBehaviour
    {
        Camera camera;
        TextureSender sender;
        Texture2D sendTexture;
        RenderTexture videoTexture;


        public RawImage image;

        // Use this for initialization
        void Start()
        {
            camera = GetComponent<Camera>();
            sender = GetComponent<TextureSender>();

            sendTexture = new Texture2D((int) camera.targetTexture.width, (int) camera.targetTexture.height);

            // Set send texture
            sender.SetSourceTexture(sendTexture);

            RenderTexture.active = camera.targetTexture;
            image.texture = camera.targetTexture;
           // ButtonNext.SetActive(false);
        }

        private int _countScreenshots;
        [SerializeField] private GameObject firstScreenshootToggle;
        [SerializeField] private GameObject secondScreenshootToggle;
        [SerializeField] private GameObject thirdScreenshootToggle;
        [SerializeField] private GameObject ImageOverlay;

        public void ScreenSender()
        {
            StartCoroutine(WaitScreenshotTime());
            RenderTexture.active = camera.targetTexture;
            sendTexture.ReadPixels(new Rect(0, 0, camera.targetTexture.width, camera.targetTexture.height), 0, 0,
                false);
            // Set preview image target

            image.texture = camera.targetTexture;
            _countScreenshots++;
           
            ScreenshotToggle();
        }
        
        //[SerializeField] private GameObject ButtonNext;
        void ScreenshotToggle()
        {
            switch (_countScreenshots)
            {
                case 1:
                    firstScreenshootToggle.SetActive(true);
                    
                    break;
                case 2:
                    secondScreenshootToggle.SetActive(true);
                    
                    break;
                case 3:
                    thirdScreenshootToggle.SetActive(true);
                   //ButtonNext.SetActive(true);
                    break;
            }
        }

        IEnumerator WaitScreenshotTime()
        {
            ImageOverlay.SetActive(true);
            yield return new WaitForSeconds(1);
            ImageOverlay.SetActive(false);
        }
    }
}