using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class StatusUI : MonoBehaviour
{
    public Canvas StatusUIs;
    public Canvas NormalStatus;
    public Canvas chillyStatus;
    public Canvas frozenStatus;
    public Canvas wasteStatus;
    public Canvas lightStatus;
    public Canvas heavyStatus;
    public TMP_Text currentStatus;
    public TMP_Text statusDesc;
    public TMP_Text chillyTimer;
    public TMP_Text frozenTimer;
    public TMP_Text wasteTimer;
    public TMP_Text lightTimer;


    ColdScript coldScript;
    NuclearScript nuclearScript;
    PlayerScript playerScript;
    PauseUI pauseUI;
    WinScript winScript;

    void Start()
    {
        StatusUIs.enabled = true;
        NormalStatus.enabled = false;
        coldScript = GameObject.Find("Frozen Area").GetComponent<ColdScript>(); 
        nuclearScript = GameObject.Find("Nuclear Waste Area").GetComponent<NuclearScript>();
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
        pauseUI = GameObject.Find("PauseUI").GetComponent<PauseUI>();
        winScript = GameObject.Find("WinUI").GetComponent<WinScript>();
        NormalStatus.enabled = false;
        chillyStatus.enabled = false;
        frozenStatus.enabled = false;
        wasteStatus.enabled = false;
        lightStatus.enabled = false;
        heavyStatus.enabled = false;
    }

    void Update()
    {
        if (pauseUI.paused == true)
        {
            StatusUIs.enabled = false;
        }
        if (pauseUI.paused == false)
        {
            StatusUIs.enabled = true;
        }
        if (playerScript.isDead == true)
        {
            StatusUIs.enabled = false;
        }
        if (winScript.win == true)
        {
            StatusUIs.enabled = false;
        }

        if (StatusUIs.enabled == true)
        {
            NormalStatus.enabled = true;
            chillyStatus.enabled = false;
            frozenStatus.enabled = false;
            wasteStatus.enabled = false;
            lightStatus.enabled = false;
            heavyStatus.enabled = false;
            if (playerScript.heavyStatus == true)
            {
                heavyStatus.enabled = true;
            }
            if (coldScript.startSlowTimer == true)
            {
                NormalStatus.enabled = false;
                chillyStatus.enabled = true;
                frozenStatus.enabled = false;
                wasteStatus.enabled = false;
                lightStatus.enabled = false;
                heavyStatus.enabled = false;
                if (playerScript.heavyStatus == true)
                {
                    heavyStatus.enabled = true;
                }
                chillyTimer.text = "Go inside to warm up\nTime until cold: " + coldScript.coldTimer.ToString("n2");
            }
            if (coldScript.regenColdTimer == true)
            {
                NormalStatus.enabled = false;
                chillyStatus.enabled = true;
                frozenStatus.enabled = false;
                wasteStatus.enabled = false;
                lightStatus.enabled = false;
                heavyStatus.enabled = false;
                if (playerScript.heavyStatus == true)
                {
                    heavyStatus.enabled = true;
                }
                chillyTimer.text = "Stay inside to warm up\nTime until warm: " + coldScript.coldTimer.ToString("n2");
            }
            if (coldScript.startDeathTimer == true)
            {
                NormalStatus.enabled = false;
                chillyStatus.enabled = false;
                frozenStatus.enabled = true;
                wasteStatus.enabled = false;
                lightStatus.enabled = false;
                heavyStatus.enabled = false;
                if (playerScript.heavyStatus == true)
                {
                    heavyStatus.enabled = true;
                }
                frozenTimer.text = "Debuff - Slowness\nTime until frozen: " + coldScript.freezeTimer.ToString("n2");
            }
            if (coldScript.regenFreezeTimer == true)
            {
                NormalStatus.enabled = false;
                chillyStatus.enabled = false;
                frozenStatus.enabled = true;
                wasteStatus.enabled = false;
                lightStatus.enabled = false;
                heavyStatus.enabled = false;
                if (playerScript.heavyStatus == true)
                {
                    heavyStatus.enabled = true;
                }
                frozenTimer.text = "Debuff - Slowness\nTime until chilly: " + coldScript.freezeTimer.ToString("n2");
            }
            if (nuclearScript.wasteDamage == true)
            {
                NormalStatus.enabled = false;
                chillyStatus.enabled = false;
                frozenStatus.enabled = false;
                wasteStatus.enabled = true;
                lightStatus.enabled = false;
                heavyStatus.enabled = false;
                if (playerScript.heavyStatus == true)
                {
                    heavyStatus.enabled = true;
                }
                wasteTimer.text = "Debuff - Damage over time\nTime until damage: " + nuclearScript.damageTimer.ToString("n2");
            }
            if (playerScript.lightStatus == true)
            {
                NormalStatus.enabled = false;
                chillyStatus.enabled = false;
                frozenStatus.enabled = false;
                wasteStatus.enabled = false;
                lightStatus.enabled = true;
                heavyStatus.enabled = false;
                if (playerScript.heavyStatus == true)
                {
                    heavyStatus.enabled = true;
                }
                lightTimer.text = "Buff - Quicker movement\nfor " + playerScript.lightTimer.ToString("n2") + " seconds!";
            }
            if (playerScript.heavyStatus == true)
            {
                heavyStatus.enabled = true;

            }
        }
        
    }
}

