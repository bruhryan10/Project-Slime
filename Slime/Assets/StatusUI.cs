using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class StatusUI : MonoBehaviour
{
    public Canvas StatusUIs;
    public GameObject normalStatus;
    public GameObject chillyStatus;
    public TMP_Text currentStatus;
    public TMP_Text statusDesc;
    public TMP_Text chillyTimer;
    ColdScript coldScript;
    NuclearScript nuclearScript;
    PlayerScript playerScript;

    void Start()
    {
        StatusUIs.enabled = true;
        coldScript = GameObject.Find("Frozen Area").GetComponent<ColdScript>(); 
        nuclearScript = GameObject.Find("Nuclear Waste Area").GetComponent<NuclearScript>();
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
        normalStatus.SetActive(false);
        chillyStatus.SetActive(false);
    }

    void Update()
    {
        if (StatusUIs.enabled == true)
        {
            normalStatus.SetActive(true);
            chillyStatus.SetActive(false);
            //currentStatus.text = "Status: Normal";
            //statusDesc.text = "You feel normal";
            if (coldScript.startSlowTimer == true)
            {
                normalStatus.SetActive(false);
                chillyStatus.SetActive(true);
                //Debug.Log("start cold timer ui");
                //currentStatus.text = "Status: Chilly";
                chillyTimer.text = "Go inside to warm up!\nTime until cold: " + coldScript.coldTimer.ToString("n2");
            }
            //if (coldScript.regenColdTimer == true)
            //{
            //    //Debug.Log("end cold timer ui");
            //    currentStatus.text = "Status: Chilly";
            //    statusDesc.text = "Stay inside to warm up!\nTime until warm: " + coldScript.coldTimer.ToString("n2");
            //}
            //if (coldScript.startDeathTimer == true)
            //{
            //    //Debug.Log("start death timer ui");
            //    currentStatus.text = "Status: COLD";
            //    statusDesc.text = "Debuff - Slowness\nTime until frozen: " + coldScript.freezeTimer.ToString("n2");
            //}
            //if (coldScript.regenFreezeTimer == true)
            //{
            //    //Debug.Log("start death timer ui");
            //    currentStatus.text = "Status: COLD";
            //    statusDesc.text = "Debuff - Slowness\nTime until chilly: " + coldScript.freezeTimer.ToString("n2");
            //}
            //if (nuclearScript.wasteDamage == true)
            //{
            //    //Debug.Log("start waste damage ui");
            //    currentStatus.text = "Status: HOT";
            //    statusDesc.text = "Debuff - Damage over time\nTime until damage: " + nuclearScript.damageTimer.ToString("n2");
            //}
            //if (playerScript.lightStatus == true)
            //{
            //    currentStatus.text = "Status: Light";
            //    statusDesc.text = "Buff - Bonus movement speed\nfor " + playerScript.lightTimer.ToString("n2") + " seconds!";
            //}
            //if (playerScript.heavyStatus == true)
            //{
            //    currentStatus.text = "Status: Heavy";
            //    statusDesc.text = "Debuff - Can't attack\nDeposit the part to be lighter!";
            //}
        }
        
    }
}

