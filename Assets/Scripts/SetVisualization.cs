using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using Microsoft.MixedReality.Toolkit.SpatialObjectMeshObserver;
using UnityEngine;

public class SetVisualization : MonoBehaviour
{
    [SerializeField] Material fireMaterial;

    public void MaterialObsercers()
    {
        SetVisualizationOfSpatialMapping(SpatialAwarenessMeshDisplayOptions.None);
    }

    public void MaterialObsercersMat()
    {
        MaterialVisualizationOfSpatialMapping(fireMaterial);
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

    public void MaterialVisualizationOfSpatialMapping(Material profile)
    {
        if (CoreServices.SpatialAwarenessSystem is IMixedRealityDataProviderAccess provider)
        {
            foreach (var observer in provider.GetDataProviders())
            {
                if (observer is IMixedRealitySpatialAwarenessMeshObserver meshObs)
                {
                    meshObs.OcclusionMaterial = profile;
                }
            }
        }
    }
}