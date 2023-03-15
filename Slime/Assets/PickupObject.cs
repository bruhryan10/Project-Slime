using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public bool canPickupItem;
    public bool heavyStatus;
    PlayerMovement playerMovement;
    PlayerScript playerScript;
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();


    }

    void Update()
    {
        if (Input.GetKey(KeyCode.M) && canPickupItem == true && playerScript.carryingItem != true)
        {
            playerScript.hasItem();
            Debug.Log("you picked up item");
            gameObject.SetActive(false);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Item")
        {
            canPickup();
            Debug.Log("enter object");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Item")
        {
            cantPickup();
            Debug.Log("leave object");
        }
    }
    public void canPickup()
    {
        canPickupItem = true;

    }
    public void cantPickup()
    {
        canPickupItem = false;
    }
}
