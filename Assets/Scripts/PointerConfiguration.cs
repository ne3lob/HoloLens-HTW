using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;

public class PointerConfiguration : MonoBehaviour
{
    public void TurnOffFarPointers()
    {
        SetFarPointersDisabled(true);
        PointerUtils.SetHandRayPointerBehavior(PointerBehavior.AlwaysOff);
    }

    public void TurnOnFarPointers()
    {
        SetFarPointersDisabled(false);
    }

    private void SetFarPointersDisabled(bool isDisabled)
    {
        FocusProvider focusProvider = (FocusProvider)MixedRealityToolkit.InputSystem.FocusProvider;
        if (focusProvider != null)
        {
            foreach (var mediator in focusProvider.PointerMediators)
            {
                CustomPointerMediator myMediator = (CustomPointerMediator)(mediator.Value);
                if (myMediator != null)
                {
                    myMediator.FarPointersDisabled = isDisabled;
                }
            }
        }
    }
}