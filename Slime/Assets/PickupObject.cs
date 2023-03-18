using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public bool canPickupPart;
    public bool heavyStatus;
    public bool canPickupKey;
    PlayerMovement playerMovement;
    PlayerScript playerScript;
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && canPickupKey == true)
        {
            playerScript.carryingKey = true;
            gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.M) && canPickupPart == true && playerScript.carryingItem != true && this.gameObject.name == "Part1")
        {
            playerScript.hasItem1();
            Debug.Log("you picked up item");
            gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.M) && canPickupPart == true && playerScript.carryingItem != true && this.gameObject.name == "Part2")
        {
            playerScript.hasItem2();
            Debug.Log("you picked up item");
            gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.M) && canPickupPart == true && playerScript.carryingItem != true && this.gameObject.name == "Part3")
        {
            playerScript.hasItem3();
            Debug.Log("you picked up item");
            gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.M) && canPickupPart == true && playerScript.carryingItem != true && this.gameObject.name == "Part4")
        {
            playerScript.hasItem4();
            Debug.Log("you picked up item");
            gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.M) && canPickupPart == true && playerScript.carryingItem != true && this.gameObject.name == "Part5")
        {
            playerScript.hasItem5();
            Debug.Log("you picked up item");
            gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.M) && canPickupPart == true && playerScript.carryingItem != true && this.gameObject.name == "Part6")
        {
            playerScript.hasItem6();
            Debug.Log("you picked up item");
            gameObject.SetActive(false);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Part")
        {
            canPickupParts();
            Debug.Log("enter object");
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Key")
        {
            canPickupKeys();
            Debug.Log("enter object");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Part")
        {
            cantPickupPart();
            Debug.Log("leave object");
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Key")
        {
            cantPickupKeys();
            Debug.Log("enter object");
        }
    }
    public void canPickupParts()
    {
        canPickupPart = true;

    }
    public void cantPickupPart()
    {
        canPickupPart = false;
    }
    public void canPickupKeys()
    {
        canPickupKey = true;
    }
    public void cantPickupKeys()
    {
        canPickupKey = false;
    }
}
