using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMenuLogic : MonoBehaviour
{
    private bool IntroWindow;
    [SerializeField] private GameObject handMenu;

    public void HandMenuActive()
    {
        if (IntroWindow)
        {
            handMenu.SetActive(true);
        }
    }

    public void HandMenuBoolToFalse()
    {
        IntroWindow = true;
    }
}