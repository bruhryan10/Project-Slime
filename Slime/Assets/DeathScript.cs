using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    public Canvas deathUI;
    public Canvas mainUI;
    PlayerScript playerScript;
    void Start()
    {
        deathUI.enabled = false;
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
    }

    void Update()
    {
        if (playerScript.isDead == true)
        {
            isDead();
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Application.Quit();
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                SceneManager.LoadScene("Labratory");
                isNotDead();
            }
        }
        
    }
    public void isDead()
    {
        mainUI.enabled = false;
        Time.timeScale = 0f;
        deathUI.enabled = true;
    }
    public void isNotDead()
    {
        mainUI.enabled = true;
        Time.timeScale = 1f;

    }
}
