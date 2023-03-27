using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    public Canvas PauseMenuUI;
    public bool paused = false;
    public bool pausedMovement;
    PlayerScript playerScript;
    void Start()
    {
        PauseMenuUI.enabled = false;
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && playerScript.isDead == false)
        {
            if (paused == true)
            {
                resumeGame();
            }
            else
            {
                pauseGame();
            }
        }
        if (paused == true && Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene("Labratory");
            resumeGame();

        }
        if (paused == true && Input.GetKeyDown(KeyCode.Z))
        {
            Application.Quit();
        }

    }
    public void resumeGame()
    {
        PauseMenuUI.enabled = false;
        Time.timeScale = 1f;
        paused = false;
        pausedMovement = false;
    }
    public void pauseGame()
    {
        PauseMenuUI.enabled = true;
        Time.timeScale = 0f;
        paused = true;
        pausedMovement = true;

    }
}
