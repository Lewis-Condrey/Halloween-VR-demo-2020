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
    public AudioSource audioSource;
    public float volume = 0.5f;
    public GameObject win;
    public GameManager GM;
    public MusicManager MM;

    void Start()
    {
        m_InteractableBase = GetComponent<XRSimpleInteractable>();
        m_InteractableBase.onSelectEnter.AddListener(conClicked);
     
        clickCount = 0;

        waveCount = 1;
    }

    void Update()
    {
        //probably a better way to do this but it was written with a the time limit in mind

        if (waveCount == 1)
        {
            Wave1();
        }
        if (waveCount == 2)
        {
            Wave2();
        }
        if (waveCount == 3)
        {
            Wave3();
        }
        if (waveCount == 4)
        {
            Wave4();
        }
        if (waveCount == 5)
        {
            Wave5();
        }
        if (waveCount == 6)
        {
            Endgame();
        }
    }

    void conClicked(XRBaseInteractor obj)
    {
        // clicking displays next text in sequence (could probably have been done with enum?
        clickCount = clickCount + 1;
        audioSource.PlayOneShot(audioSource.clip, volume);
    }

    public void Endgame()
    {
        Spawner.killed = 0;
        if (clickCount == 0)
        {
            displayText.text = "...";
        }
        if (clickCount == 1)
        {
            displayText.text = "Congratulations.";
        }
        if (clickCount == 2)
        {
            displayText.text = "If you thought you were talking to your peers, you are mistaken.";
        }
        if (clickCount == 3)
        {
            displayText.text = "We just needed to buy some time.";
            //Instantiate(win);
        }
        if (clickCount == 4)
        {
            win.SetActive(true);
            MM.EndTheme();
            displayText.text = "You should turn around " + (Environment.UserName);
            clickCount = +1;
        }
        if (clickCount == 6)
        {
            displayText.text = "press to end";

        }
        if (clickCount > 6)
        {
            GM.Win();
        }

    }

    public void Wave1()
    {
        
       if(clickCount == 0)
        {
            displayText.text = "Start";
        }
        if (clickCount == 1)
        {
            displayText.text = "You have been tasked to study this enviroment.";
        }
        if (clickCount == 2)
        {
            displayText.text = "Extraction is in the morning.";
        }
        if (clickCount == 3)
        {
            displayText.text = "If you see anything unusual be sure to shine your flashlight at it, don't let them get to the window";
        }
        if (clickCount == 4)
        {
            displayText.text = "Good luck.";
        }
        if (clickCount == 5)
        {
            displayText.text = "Objective: Survive";
            Spawner.killed = 0;
            NextWave();
            clickCount = clickCount + 1;
        }
        if (clickCount > 5)
        {
            displayText.text = "Objective: Survive";
            if (Spawner.killed == Spawner.spawned)
            {
                waveCount = waveCount + 1;
                clickCount = 0;
            }
        }
    }

    public void Wave2()
    {

        if (clickCount == 0)
        {
            displayText.text = "Continue";
        }
        if (clickCount == 1)
        {
            displayText.text = "Good, you're still alive.";
        }
        if (clickCount == 2)
        {
            displayText.text = "we're detecting another wave incoming.";
        }
        if (clickCount == 3)
        {
            displayText.text = "Objective: Survive";
            Spawner.killed = 0;
            NextWave();
            clickCount = clickCount + 1;
        }
        if (clickCount > 3)
        {
            displayText.text = "Objective: Survive";
            if (Spawner.killed == Spawner.spawned)
            {
                waveCount = waveCount + 1;
                clickCount = 0;
            }
        }
    }

    public void Wave3()
    {
        if (clickCount == 0)
        {
            displayText.text = "Continue";
        }

        if (clickCount == 1)
        {
            displayText.text = "You aren't clear just yet, just keep it up.";
        }

        if (clickCount == 2)
        {
            displayText.text = "Objective: Survive";
            Spawner.killed = 0;
            NextWave();
            clickCount = clickCount + 1;
        }

        if (clickCount > 2)
        {
            displayText.text = "Objective: Survive";
            if (Spawner.killed == Spawner.spawned)
            {
                waveCount = waveCount + 1;
                clickCount = 0;
            }
        }
        }

    public void Wave4()
    {

        if (clickCount == 0)
        {
            displayText.text = "Continue";
        }
        if (clickCount == 1)
        {
            displayText.text = "You're doing great! the data we've collected is very promising.";
        }
        if (clickCount == 2)
        {
            displayText.text = "Just keep at it and don't ask questions ok?";
        }
        if (clickCount == 3)
        {
            displayText.text = "Objective: Survive";
            Spawner.killed = 0;
            NextWave();
            clickCount = clickCount + 1;
        }
        if (clickCount > 3)
        {
            displayText.text = "Objective: Survive";
            if (Spawner.killed == Spawner.spawned)
            {
                waveCount = waveCount + 1;
                clickCount = 0;
            }
        }
    }
    public void Wave5()
        {
            if (clickCount == 0)
            {
                displayText.text = "Hello?";
            }
             if (clickCount == 1)
            {
                displayText.text = "You get past this last wave and you're safe.";
            }
              if (clickCount == 2)
            {
                displayText.text = "We will come pick you up once the activity has stopped.";
            } 
                if (clickCount == 3)
            {
                displayText.text = "Good luck, we believe in you.";
            }

            if (clickCount == 4)
            {
                displayText.text = "Objective: Survive";
                Spawner.killed = 0;
                NextWave();
                clickCount = clickCount + 1;
            }

            if (clickCount > 4)
            {
                displayText.text = "Objective: Survive";
                if (Spawner.killed == Spawner.spawned)
                {
                    waveCount = waveCount + 1;
                    clickCount = 0;
                }
            }
        }




    void NextWave()
    {
        Spawner.NextWave();
    }

}


