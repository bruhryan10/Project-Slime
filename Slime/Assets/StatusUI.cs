using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class StatusUI : MonoBehaviour
{
    public Canvas StatusUIs;
    public TMP_Text frozenTimer;
    ColdScript coldScript;
    NuclearScript nuclearScript;
    PlayerScript playerScript;

    void Start()
    {
        StatusUIs.enabled = true;
        coldScript = GameObject.Find("Frozen Area").GetComponent<ColdScript>(); 
        nuclearScript = GameObject.Find("Nuclear Waste Area").GetComponent<NuclearScript>();
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
    }

    void Update()
    {
        if (StatusUIs.enabled == true)
        {
            frozenTimer.text = "Status: Warm";
            if (coldScript.startSlowTimer == true)
            {
                //Debug.Log("start cold timer ui");
                frozenTimer.text = "Status: Chilly\nTime until \nCold: " + coldScript.coldTimer.ToString("n2");
            }
            if (coldScript.regenColdTimer == true)
            {
                //Debug.Log("end cold timer ui");
                frozenTimer.text = "Status: Chilly\nTime until \nWarm: " + coldScript.coldTimer.ToString("n2");
            }
            if (coldScript.startDeathTimer == true)
            {
                //Debug.Log("start death timer ui");
                frozenTimer.text = "Status: Cold\nTime until \nFrozen: " + coldScript.freezeTimer.ToString("n2");
            }
            if (coldScript.regenFreezeTimer == true)
            {
                //Debug.Log("start death timer ui");
                frozenTimer.text = "Status: Cold\nTime until \nChilly: " + coldScript.freezeTimer.ToString("n2");
            }
            if (nuclearScript.wasteDamage == true)
            {
                //Debug.Log("start waste damage ui");
                frozenTimer.text = "Status: Hot\nTime until \nDamage: " + nuclearScript.damageTimer.ToString("n2");
            }
            if (playerScript.lightStatus == true)
            {
                frozenTimer.text = "Status: Light\nMove quicker \nFor: " + playerScript.lightTimer.ToString("n2");
            }
            if (playerScript.heavyStatus == true)
            {
                frozenTimer.text = "Status: Heavy\nSome debuff\nText here";
            }
        }
        
    }
}

