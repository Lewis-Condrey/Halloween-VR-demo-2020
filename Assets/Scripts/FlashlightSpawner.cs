using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightSpawner : MonoBehaviour
{
    public Transform SpawnPoint;

    void OnTriggerEnter(Collider Collider)
    {
        if (Collider.tag == "Respawn")
        {
            transform.position = SpawnPoint.position;
        }
    }
}