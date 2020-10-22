using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Experimental.XR;

public class FlashLight : MonoBehaviour
{
    public bool flashlightON;
    private bool waitForRelease;
    public Light theLight;
    XRGrabInteractable m_InteractableBase;

    private void Start()
    {
        theLight = GetComponentInChildren<Light>();
        flashlightON = false;
        theLight.enabled = false;
        waitForRelease = false;
        m_InteractableBase = GetComponent<XRGrabInteractable>();
        m_InteractableBase.onActivate.AddListener(TriggerPulled);
        m_InteractableBase.onSelectExit.AddListener(Dropped);


    }
    void TriggerPulled(XRBaseInteractor obj)
    {
        if (flashlightON == false)
        {
            LightON();
            flashlightON = true;
            //Debug.Log("funny");
            return;
        }
        if (flashlightON == true)
        {
            LightOFF();
            flashlightON = false;
            return;
        }
    }

    void Dropped(XRBaseInteractor obj)
    {
        LightOFF();
    }

    public void LightON()
    { 
        flashlightON = true;
        theLight.enabled = true;
    }

    public void LightOFF()
    {
        flashlightON = false;
        theLight.enabled = false;
    }
}
