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
    public Spawner Spawner;
    public int clickCount;
    public int waveCount;


    void Start()
    {
        m_InteractableBase = GetComponent<XRSimpleInteractable>();
        m_InteractableBase.onSelectEnter.AddListener(conClicked);
        

        //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        //string userName = (Environment.UserName);
        //Debug.Log(Environment.UserName);

        // DisplayText();
        //displayText.text = "" + textToDisplay;

        //displayText.text = "What ever you want to display";

        clickCount = 0;

        waveCount = 1;

    }

    void Update()
    {
        if (waveCount == 1)
        {
            Wave1();
        }
    }

    public void DisplayText() {
        //displayText.text = "What ever you want to display";

        //displayText.text = (Environment.UserName);

        //displayText.text = 

        //displayText.text = "Hello " + (Environment.UserName);

    }

    public void Clicked()
    {
        Debug.Log("Bönk");
    }

    void conClicked(XRBaseInteractor obj)
    {
        clickCount = clickCount + 1;
        Debug.Log(clickCount);
    }

    public void Wave1()
    {
        
       if(clickCount == 1)
        {
            displayText.text = "Start";
        }
        if (clickCount == 2)
        {
            displayText.text = "You have been tasked to study this enviroment.";
        }
        if (clickCount == 3)
        {
            displayText.text = "Extraction is in the morning";
        }
        if (clickCount == 4)
        {
            displayText.text = "If you see anything unusual be sure to shine your flashlight at it.";
        }
        if (clickCount == 5)
        {
            displayText.text = "Good luck";
        }
        if (clickCount == 6)
        {
            displayText.text = "Objective: Survive";
            Spawner.Play();
        }
        if (clickCount > 6)
        {
            displayText.text = "Objective: Survive";
        }
    }

    void Wave2()
    {

    }

}


