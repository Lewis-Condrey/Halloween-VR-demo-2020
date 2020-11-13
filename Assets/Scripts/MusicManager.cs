using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip mainTheme;
    public AudioClip endTheme;

    public AudioSource Audio;

    public float time;
    public bool mplay;

    void Start()
    {
        // you need a reference to your component
        Audio = gameObject.GetComponent<AudioSource>();
        time = 20;
        mplay = true;
    }

    private void Update()
    {
        if(mplay == false)
        {
            time -= Time.deltaTime;
            if(time < 0)
            {
                MainTheme();
            }
        }
        if(mplay == true)
        {
            return;
        }
    }

    public void MainTheme()
    {
       
        Audio.clip = mainTheme;
        Audio.Play();
        time = 20;
        mplay = true;
    }

    public void EndTheme()
    {
        Audio.clip = endTheme;
        Audio.Play();
        mplay = false;
    }


}
