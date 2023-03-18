using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class MainUIScript : MonoBehaviour
{

    public Canvas mainUI;
    public TMP_Text currentHealth;
    public TMP_Text attackTimer;
    public TMP_Text textBelow;
    public TMP_Text Key;
    public TMP_Text NoItems;
    PlayerScript playerScript;
    PauseUI pauseUI;

    void Start()
    {
        mainUI.enabled = true;
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
        pauseUI = GameObject.Find("PauseUI").GetComponent<PauseUI>();
        Key.enabled = false;
    }

    void Update()
    {
        if (mainUI.enabled == true)
        {
            currentHealth.text = "Health: " + playerScript.PlayerHealth + "HP";
            attackTimer.text = "Attack Cooldown: 10.11";
            textBelow.text = "Extra Placeholder Text";
            
            if (playerScript.carryingKey == true)
            {
                NoItems.enabled = false;
                Key.enabled = true;
            }
        }
        if (pauseUI.paused == true)
        {
            mainUI.enabled = false;
        }
        if (pauseUI.paused == false)
        {
            mainUI.enabled = true;
        }
    }
}
