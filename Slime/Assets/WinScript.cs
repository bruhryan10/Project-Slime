using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class WinScript : MonoBehaviour
{
    DepositArea depositArea;
    public Canvas winUI;
    public TMP_Text winTimer;
    public GameObject background;
    public float rocketTimer = 5f;
    public Canvas mainUI;
    public bool win;
    void Start()
    {
        depositArea = GameObject.Find("Deposit Area").GetComponent<DepositArea>();
        winUI.enabled = false;

    }

    void Update()
    {
        if (depositArea.depNumber == 6)
        {
            WinTImer();
            rocketTimer -= Time.deltaTime;
            if (rocketTimer < 0)
            {
                didWin();
                if (Input.GetKeyDown(KeyCode.B))
                {
                    Time.timeScale = 1f;
                    mainUI.enabled = true;
                    SceneManager.LoadScene("Labratory");

                }
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    Application.Quit();
                }
            }
        }
    }
    public void WinTImer()
    {
        winUI.enabled = true;
        winTimer.text = "Time until takeoff: " + rocketTimer.ToString("n2") + "s";
        background.gameObject.SetActive(false);
    }
    public void didWin()
    {
        win = true;
        Time.timeScale = 0f;
        mainUI.enabled = false;
        background.gameObject.SetActive(true);
        winTimer.text = "Congrats! you won!\nPress Z to Quit\nPress B to restart";

    }
}
