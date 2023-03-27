using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColdScript : MonoBehaviour
{

    public bool startSlowTimer;
    public bool startDeathTimer;
    public bool slowedMovement;
    public float coldTimer = 20f;
    public float freezeTimer = 40f;
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
            regenSpeed = Time.deltaTime * 3f;
            freezeTimer += regenSpeed;
            if (freezeTimer > 40)
            {
                regenFreezeTimer = false;
                regenColdTimer = true;
                slowedMovement = false;
                coldTimer += regenSpeed;
                freezeTimer = 40f;
                if (coldTimer > 20)
                {
                    regenColdTimer = false;
                    regenTimers = false;
                    coldTimer = 20f;
                }
            }
        }

    }

    public void startFreeze()
    {
        regenTimers = false;
        regenFreezeTimer = false;
        regenColdTimer = false;
        startSlowTimer = true;
    }
    public void endFreeze()
    {
        startSlowTimer = false;
        regenTimers = true;
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
