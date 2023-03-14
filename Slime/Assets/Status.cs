using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class Status : MonoBehaviour
{
    //public Canvas MainUI;
    //public TMP_Text frozenTimer;
    //ColdScript coldScript;

    void Start()
    {
        //MainUI.enabled = true;
        //coldScript = GameObject.Find("Frozen Area").GetComponent<ColdScript>(); // Calling the cold script, where I can pull the bools and floats        
    }

    void Update()
    {
        //if (MainUI.enabled == true)
        //{
            //frozenTimer.text = "Status: Warm";
            //if (coldScript.startSlowTimer == true)
            //{
                //Debug.Log("start cold timer ui");
                //frozenTimer.text = "Status: Chilly\nTime until \nCold: " + coldScript.coldTimer.ToString("n2");
            //}
            //if (coldScript.regenColdTimer == true)
            //{
                //Debug.Log("end cold timer ui");
                //frozenTimer.text = "Status: Chilly\nTime until \nWarm: " + coldScript.coldTimer.ToString("n2");
            //}
            //if (coldScript.startDeathTimer == true)
            //{
                //Debug.Log("start death timer ui");
                //frozenTimer.text = "Status: Cold\nTime until \nFrozen: " + coldScript.freezeTimer.ToString("n2");
           //}
            //if (coldScript.regenFreezeTimer == true)
            //{
                //Debug.Log("start death timer ui");
                //frozenTimer.text = "Status: Cold\nTime until \nChilly: " + coldScript.freezeTimer.ToString("n2");
            //}
        //}
        
    }
}
