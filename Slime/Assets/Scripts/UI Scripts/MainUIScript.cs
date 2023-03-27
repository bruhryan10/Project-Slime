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
    public TMP_Text Key;
    public TMP_Text NoItems;
    public TMP_Text KeyCard;
    public TMP_Text Crowbar;
    PlayerScript playerScript;
    PauseUI pauseUI;
    WinScript winScript;

    void Start()
    {
        mainUI.enabled = true;
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
        pauseUI = GameObject.Find("PauseUI").GetComponent<PauseUI>();
        winScript = GameObject.Find("WinUI").GetComponent<WinScript>();
        Key.enabled = false;
        KeyCard.enabled = false;
        Crowbar.enabled = false;
    }

    void Update()
    {
        if (mainUI.enabled == true)
        {
            currentHealth.text = "HP: " + playerScript.PlayerHealth;
            
            if (playerScript.carryingKey == true)
            {
                NoItems.enabled = false;
                Key.enabled = true;
            }
            if (playerScript.carryingKeyCard == true)
            {
                NoItems.enabled = false;
                KeyCard.enabled = true;
            }
            if (playerScript.carryingCrowbar == true)
            {
                NoItems.enabled = false;
                Crowbar.enabled = true;
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
        if (playerScript.isDead == true)
        {
            mainUI.enabled = false;
        }
        if (winScript.win == true)
        {
            mainUI.enabled = false;
        }
    }
}
