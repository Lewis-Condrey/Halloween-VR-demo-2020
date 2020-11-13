using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody myrb;
    public float moveSpeed;
    public GameObject player;
    public GameManager GM;

    // Start is called before the first frame update
    void Start()
    {
        myrb = GetComponent<Rigidbody>();

        GM = FindObjectOfType<GameManager>();
        
    }


    void FixedUpdate()
    {
        //move the enemy object towards the player
            myrb.velocity = (transform.forward * moveSpeed);
        transform.LookAt(player.transform.position);
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        //when enemy colliders with the players space it triggers the death/boo screen
        if (collisionInfo.collider.tag == "Player")
        {
            GM.onDeath();
        }
    }
}
