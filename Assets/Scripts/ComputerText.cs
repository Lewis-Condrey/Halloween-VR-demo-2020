using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Experimental.XR;
using UnityEngine.UI;

public class ComputerText : MonoBehaviour
{
    public Text displayText;
    XRGrabInteractable m_InteractableBase;
    //public string textToDisplay;


    void Start()
    {
        DisplayText();
        //displayText.text = "" + textToDisplay;
    }

    public void DisplayText() {
       displayText.text = "What ever you want to display";
 }
}


