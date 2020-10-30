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
            Destroy(gameObject);
        }
        else { return; }
    }
}
