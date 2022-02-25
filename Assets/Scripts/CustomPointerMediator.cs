using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Input;

public class CustomPointerMediator : DefaultPointerMediator
{
    public bool FarPointersDisabled { get; set; }

    public override void UpdatePointers()
    {
        base.UpdatePointers();
        if (FarPointersDisabled)
        {
            foreach (var pointer in farInteractPointers)
            {
                pointer.IsActive = false;
            }
        }
    }
}