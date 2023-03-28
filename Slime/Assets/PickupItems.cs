using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class PickupItems : MonoBehaviour
{
    public bool canPickupKey;
    public bool canPickupKeyCard;
    public bool canPickupCrowbar;
    PlayerScript playerScript;
    public Canvas interactUI;
    void Start()
    {
        interactUI.enabled = false;
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canPickupKey == true)
        {
            playerScript.carryingKey = true;
            gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.F) && canPickupCrowbar == true)
        {
            playerScript.carryingCrowbar = true;
            gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.F) && canPickupKeyCard == true)
        {
            playerScript.carryingKeyCard = true;
            gameObject.SetActive(false);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Key")
        {
            interactUI.enabled = true;
            canPickupKey = true;
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "KeyCard")
        {
            interactUI.enabled = true;
            canPickupKeyCard = true;
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Crowbar")
        {
            interactUI.enabled = true;
            canPickupCrowbar = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Key")
        {
            interactUI.enabled = false;
            canPickupKey = false;
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "KeyCard")
        {
            interactUI.enabled = false;
            canPickupKeyCard = false;
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Crowbar")
        {
            interactUI.enabled = false;
            canPickupCrowbar = false;
        }
    }
}
