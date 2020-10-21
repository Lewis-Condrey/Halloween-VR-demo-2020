using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public bool flashlightON;
    public bool flashlightOFF;
 
    public Light theLight;

    private void Start()
    {
        theLight = GetComponentInChildren<Light>();
        flashlightOFF = true;
        flashlightON = false;
        theLight.enabled = false;
    }

    public void LightON()
    {
        flashlightOFF = false;
        flashlightON = true;
        theLight.enabled = true;
    }

    public void LightOFF()
    {
        flashlightOFF = true;
        flashlightON = false;
        theLight.enabled = false;
    }
}
