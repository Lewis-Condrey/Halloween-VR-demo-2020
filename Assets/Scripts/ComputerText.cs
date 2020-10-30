using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Experimental.XR;
using UnityEngine.UI;
using System;


public class ComputerText : MonoBehaviour
{
    public Text displayText;
    XRSimpleInteractable m_InteractableBase;
    //public string textToDisplay;
    string userName;


    void Start()
    {
        m_InteractableBase = GetComponent<XRSimpleInteractable>();
        m_InteractableBase.onSelectEnter.AddListener(conClicked);

        //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        string userName = (Environment.UserName);
        Debug.Log(Environment.UserName);

        DisplayText();
        //displayText.text = "" + textToDisplay;
    }

    public void DisplayText() {
        //displayText.text = "What ever you want to display";

        //displayText.text = (Environment.UserName);

        //displayText.text = 
    }

    public void Clicked()
    {
        Debug.Log("Bönk");
    }

    void conClicked(XRBaseInteractor obj)
    {
        Debug.Log("Bönk");
    }

}


