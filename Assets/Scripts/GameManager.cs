using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject boo;
    public GameObject stage;
    public GameObject canvas;
    public GameObject ghoul;
    public float restartDelay = 1f;
    public MusicManager music;

    public void onDeath()
    {
        // here I am adding UI for the death/boo screen and clearing the scene of anything that would move through it before restarting the stage 
        music.EndTheme();
        boo.SetActive(true);
        stage.SetActive(false);
        canvas.SetActive(false);
        InvokeRepeating("Clear", 0, 0.1f);
        Invoke("Restart", restartDelay);

    }

    void Restart()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     
    }

    void Clear()
    {
        Destroy(GameObject.Find("Flashlight"));
        Destroy(GameObject.Find("Flashlight (1)"));

        if (GameObject.Find("ghoul(Clone)") != null)
        {
            Destroy(GameObject.Find("ghoul(Clone)"));
        }
        

    }

   public void Win()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
   
}
