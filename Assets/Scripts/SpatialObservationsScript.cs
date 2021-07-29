// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    /// <summary>
    /// This class demonstrates clearing spatial observations.
    /// </summary>
    [AddComponentMenu("Scripts/MRTK/Examples/ClearSpatialObservations")]
    public class SpatialObservationsScript : MonoBehaviour
    {
        /// <summary>
        /// Indicates whether observations are to be cleared (true) or if the observer is to be resumed (false).
        /// </summary>
        private bool clearObservations = false;

        [SerializeField] private GameObject buttonPlaceObject;
        [SerializeField] private Material myMaterial;
        [SerializeField] private GameObject sphere;
        [SerializeField] private Material sphereMatSuspend;
        [SerializeField] private Material sphereMatResume;

        /// <summary>
        /// Toggles the state of the observers.
        /// </summary>
        ///
        private void Start()
        {
            buttonPlaceObject.SetActive(false);
            //CoreServices.SpatialAwarenessSystem.SuspendObservers();
        }

        public void ToggleObservers()
        {
            var spatialAwarenessSystem = CoreServices.SpatialAwarenessSystem;
            if (spatialAwarenessSystem != null)
            {
                if (clearObservations)
                {
                    //spatialAwarenessSystem.SuspendObservers();
                    clearObservations = false;
                    sphere.GetComponent<Renderer>().material = sphereMatSuspend;
                }
                else
                {
                    //spatialAwarenessSystem.ResumeObservers();
                    clearObservations = true;
                    buttonPlaceObject.SetActive(true);
                    sphere.GetComponent<Renderer>().material = sphereMatResume;
                }
            }
        }
    }
}