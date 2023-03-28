using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class DepositArea : MonoBehaviour
{
    public bool canDepositItem;
    PlayerScript playerScript;
    public GameObject partPickup;
    public GameObject partPickup2;
    public GameObject partPickup3;
    public GameObject partPickup4;
    public GameObject partPickup5;
    public GameObject partPickup6;
    public float depNumber;
    public Canvas placeUI;

    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
        placeUI.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canDepositItem == true && playerScript.carryingItem1 == true)
        {
            Instantiate(partPickup).transform.position = new Vector3(-49.5f, 40.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem1 = false;
            playerScript.carryingItem = false;
            depNumber += 1;
        }
        if (Input.GetKeyDown(KeyCode.F) && canDepositItem == true && playerScript.carryingItem2 == true)
        {
            Instantiate(partPickup2).transform.position = new Vector3(-49.5f, 40.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem2 = false;
            playerScript.carryingItem = false;
            depNumber += 1;
        }
        if (Input.GetKeyDown(KeyCode.F) && canDepositItem == true && playerScript.carryingItem3 == true)
        {
            Instantiate(partPickup3).transform.position = new Vector3(-49.5f, 40.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem3 = false;
            playerScript.carryingItem = false;
            depNumber += 1;
        }
        if (Input.GetKeyDown(KeyCode.F) && canDepositItem == true && playerScript.carryingItem4 == true)
        {
            Instantiate(partPickup4).transform.position = new Vector3(-49.5f, 40.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem4 = false;
            playerScript.carryingItem = false;
            depNumber += 1;
        }
        if (Input.GetKeyDown(KeyCode.F) && canDepositItem == true && playerScript.carryingItem5 == true)
        {
            Instantiate(partPickup5).transform.position = new Vector3(-49.5f, 40.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem5 = false;
            playerScript.carryingItem = false;
            depNumber += 1;
        }
        if (Input.GetKeyDown(KeyCode.F) && canDepositItem == true && playerScript.carryingItem6 == true)
        {
            Instantiate(partPickup6).transform.position = new Vector3(-49.5f, 40.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem6 = false;
            playerScript.carryingItem = false;
            depNumber += 1;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Deposit" && playerScript.carryingItem == true)
        {
            placeUI.enabled = true;
            canDepositItem = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Deposit")
        {
            placeUI.enabled = false;
            canDepositItem = false;
        }
    }
}
