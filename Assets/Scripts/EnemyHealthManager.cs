using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Experimental.XR;

public class EnemyHealthManager : MonoBehaviour
{
    public Spawner spawner;
    public FlashLight fLight;
    public Light theLight;
    XRGrabInteractable m_InteractableBase;
    //public ParticleSystem particles;
    public GameObject particles;
   // public AudioSource audioSource;
    //public float volume = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        spawner = FindObjectOfType<Spawner>();
        
    }

    public void EnemyDie()
    {
        // if(fLight.flashlightON == true)
        if (FlashLight.flashlightON == true)
        {
            spawner.killed = spawner.killed + 1;
            Debug.Log("ghoul dead");
           // audioSource.PlayOneShot(audioSource.clip, volume);
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else { return; }
    }
}
