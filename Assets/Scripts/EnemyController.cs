using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody myrb;
    public float moveSpeed;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        myrb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        if (GameObject.Find("Player") != null)
            myrb.velocity = (transform.forward * moveSpeed);
        transform.LookAt(player.transform.position);
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            Debug.Log("ded");
        }
    }
}
