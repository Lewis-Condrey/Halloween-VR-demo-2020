using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Experimental.XR;

public class FlashLight : MonoBehaviour
{
    public static bool flashlightON;
    public Light theLight;
    XRGrabInteractable m_InteractableBase;
    public AudioSource audioSource;
    public float volume = 0.5f;

    private void Start()
    {
        theLight = GetComponentInChildren<Light>();
        flashlightON = false;
        theLight.enabled = false;
        m_InteractableBase = GetComponent<XRGrabInteractable>();
        m_InteractableBase.onActivate.AddListener(TriggerPulled);
        m_InteractableBase.onSelectExit.AddListener(Dropped);
    }

    void TriggerPulled(XRBaseInteractor obj)
    {
        audioSource.PlayOneShot(audioSource.clip, volume);
        if (flashlightON == false)
        {
            LightON();
            flashlightON = true;
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
