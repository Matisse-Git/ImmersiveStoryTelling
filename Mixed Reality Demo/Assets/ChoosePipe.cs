using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace UnityEngine.XR.Interaction.Toolkit
{
    public class ChoosePipe : BaseTeleportationInteractable
    {

        protected override bool GenerateTeleportRequest(XRBaseInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest)
        {
            teleportRequest.destinationPosition = raycastHit.point;
            return true;
        }
    }
}

