using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class PickupObject : MonoBehaviour
{
    public Canvas interactUI;
    public bool canPickupPart;
    public bool heavyStatus;
    public bool canPickupKey;
    public bool canPickupFriend;
    public bool canPickupKeyCard;
    public bool canPickupCrowbar;
    PlayerMovement playerMovement;
    PlayerScript playerScript;
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
        interactUI.enabled = false;


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
        if (Input.GetKeyDown(KeyCode.F) && canPickupFriend == true)
        {
            playerScript.PlayerHealth += 1;
            gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.F) && canPickupPart == true && playerScript.carryingItem != true && this.gameObject.name == "Part1")
        {
            playerScript.hasItem1();
            gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.F) && canPickupPart == true && playerScript.carryingItem != true && this.gameObject.name == "Part2")
        {
            playerScript.hasItem2();
            gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.F) && canPickupPart == true && playerScript.carryingItem != true && this.gameObject.name == "Part3")
        {
            playerScript.hasItem3();
            gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.F) && canPickupPart == true && playerScript.carryingItem != true && this.gameObject.name == "Part4")
        {
            playerScript.hasItem4();
            gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.F) && canPickupPart == true && playerScript.carryingItem != true && this.gameObject.name == "Part5")
        {
            playerScript.hasItem5();
            gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.F) && canPickupPart == true && playerScript.carryingItem != true && this.gameObject.name == "Part6")
        {
            playerScript.hasItem6();
            gameObject.SetActive(false);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Part")
        {
            interactUI.enabled = true;
            canPickupPart = true;
        }
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
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Friend")
        {
            //Debug.Log("Bruh");
            interactUI.enabled = true;
            canPickupFriend = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Part")
        {
            canPickupPart = false;
            interactUI.enabled = false;
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Key")
        {
            canPickupKey = false;
            interactUI.enabled = false;
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Friend")
        {
            canPickupFriend = false;
            interactUI.enabled = false;
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "KeyCard")
        {
            canPickupKeyCard = false;
            interactUI.enabled = false;
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Crowbar")
        {
            canPickupCrowbar = false;
            interactUI.enabled = false;
        }
    }
}
