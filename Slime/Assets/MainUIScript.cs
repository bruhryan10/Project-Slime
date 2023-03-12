using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

//for UI elements, have to add those three new unity engine elements
public class MainUIScript : MonoBehaviour
{
    public Canvas MainUI;
    public TMP_Text frozenTimer;
    ColdScript coldScript; //making cold script a variable



    // Start is called before the first frame update
    void Start()
    {
        MainUI.enabled = true; //some UIs you want disabled on start as they would pop up later, good to remember if this is or not
        coldScript = GameObject.Find("Frozen Area").GetComponent<ColdScript>(); // Calling the cold script, where I can pull the bools and floats

    }

    // Update is called once per frame
    void Update()
    {
        if (MainUI.enabled == true)
        {
            frozenTimer.text = "Status: Warm\nYou are not\ncold/freezing!";
            if (coldScript.startSlowTimer == true)
            {
                //Debug.Log("start cold timer ui");
                frozenTimer.text = "Status: Chilly\nTime until \nCold: " + coldScript.coldTimer.ToString("n2");
                //setting the written text + time until cold + n2 is limiting number length so it isnt 1.923456823567823785
            }
            if (coldScript.regenColdTimer == true)
            {
                //Debug.Log("end cold timer ui");
                frozenTimer.text = "Status: Chilly\nTime until \nWarm: " + coldScript.coldTimer.ToString("n2");
                //setting the written text + time until cold is regened
            }
            if (coldScript.startDeathTimer == true)
            {
                Debug.Log("start death timer ui");
                frozenTimer.text = "Status: Cold\nTime until \nFrozen: " + coldScript.freezeTimer.ToString("n2");
            }
            if (coldScript.regenFreezeTimer == true)
            {
                Debug.Log("start death timer ui");
                frozenTimer.text = "Status: Cold\nTime until \nChilly: " + coldScript.freezeTimer.ToString("n2");
            }
        }

    }

}
