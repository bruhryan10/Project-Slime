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
    public bool regenTimers;
    public bool regenColdTimer;
    public bool regenFreezeTimer;
    public float regenSpeed = 0;


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
                //death code is run here
            }
        }
        if (regenTimers == true)
        {
            regenFreezeTimer = true;
            regenSpeed = Time.deltaTime * 2f;
            freezeTimer += regenSpeed;
            if (freezeTimer > 20)
            {
                regenFreezeTimer = false;
                regenColdTimer = true;
                coldTimer += regenSpeed;
                freezeTimer = 20f;
                if (coldTimer > 10)
                {
                    regenColdTimer = false;
                    regenTimers = false;
                    coldTimer = 10f;
                }
            }
        }

    }

    public void startFreeze()
    {
        regenTimers = false;
        startSlowTimer = true;
    }
    public void endFreeze()
    {
        regenTimers = true;
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
