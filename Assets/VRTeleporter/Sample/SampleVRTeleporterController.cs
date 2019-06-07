using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;

public class SampleVRTeleporterController : MonoBehaviour {

    public VRTeleporter teleporter;

	void Update () {
         if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            teleporter.ToggleDisplay(true);
        }
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            teleporter.Teleport();
            teleporter.ToggleDisplay(false);
        }
	}
}
