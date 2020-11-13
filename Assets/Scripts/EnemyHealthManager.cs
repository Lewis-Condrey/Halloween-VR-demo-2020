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
    public GameObject particles;


    // Start is called before the first frame update
    void Start()
    {
        spawner = FindObjectOfType<Spawner>();
        
    }

    public void EnemyDie()
    {
// make sure enemy can only die if the light is pointed at them and turned on
        if (FlashLight.flashlightON == true)
        {
            spawner.killed = spawner.killed + 1;
            Debug.Log("ghoul dead");
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else { return; }
    }

    public void restart()
    {
        Destroy(gameObject);
    }

}
