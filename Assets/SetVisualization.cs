using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using UnityEngine;

public class SetVisualization : MonoBehaviour
{
    public void MaterialObsercers()
    {
        SetVisualizationOfSpatialMapping(SpatialAwarenessMeshDisplayOptions.None);
    }

    public void SetVisualizationOfSpatialMapping(SpatialAwarenessMeshDisplayOptions option)
    {
        if (CoreServices.SpatialAwarenessSystem is IMixedRealityDataProviderAccess provider)
        {
            foreach (var observer in provider.GetDataProviders())
            {
                if (observer is IMixedRealitySpatialAwarenessMeshObserver meshObs)
                {
                    meshObs.DisplayOption = option;
                }
            }
        }
        
        
    }
}