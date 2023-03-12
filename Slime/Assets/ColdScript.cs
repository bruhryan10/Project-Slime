using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColdScript : MonoBehaviour
{

    public bool startSlowTimer;
    public bool startDeathTimer;
    public bool slowedMovement;
    public float coldTimer = 10f;
    public float freezeTimer = 20f;
    public bool regenColdTimers;

    void Start()
    {
    }

    void Update()
    {
        if (startSlowTimer == true)
        {
            coldTimer -= Time.deltaTime;
            if (coldTimer < 0)
            {
                slowedMovement = true;
                Debug.Log("you are now slowed!!!");
                startDeathTimer = true;
                startSlowTimer = false;
            }
        }
        if (startDeathTimer == true)
        {
            freezeTimer -= Time.deltaTime;
            if (freezeTimer < 0)
            {
                startDeathTimer = false;
                Debug.Log("Freeze timer is up! you are dead");
            }
        }
        if (regenColdTimers == true)
        {
            freezeTimer += Time.deltaTime;
            if (freezeTimer > 20)
            {
                coldTimer += Time.deltaTime;
                freezeTimer = 20f;
                if (coldTimer > 10)
                {
                    regenColdTimers = false;
                    coldTimer = 10f;
                }
            }
        }

    }

    public void startFreeze()
    {
        startSlowTimer = true;
    }
    public void endFreeze()
    {
        regenColdTimers = true;
        slowedMovement = false;
        startSlowTimer = false;
        startDeathTimer = false;
        //Debug.Log("this code has run");
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //when player with the player tag enters the collider object with the tag frozen
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Frozen")
        {
            regenColdTimers = false;
            startFreeze();
            Debug.Log("enter");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //when player with the player tag leaves the collider object with the tag frozen
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Frozen")
        {
            endFreeze();
            Debug.Log("Exit");
        }
    }
}
