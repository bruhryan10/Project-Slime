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
    PlayerScript playerScript;
    PauseUI pauseUI;

    void Start()
    {
        mainUI.enabled = true;
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
        pauseUI = GameObject.Find("PauseUI").GetComponent<PauseUI>();
    }

    void Update()
    {
        if (mainUI.enabled == true)
        {
            currentHealth.text = "Health: " + playerScript.PlayerHealth + "HP";
            attackTimer.text = "Attack Cooldown: 10.11";
            textBelow.text = "Extra Placeholder Text";
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
