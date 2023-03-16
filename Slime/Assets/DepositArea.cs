using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && canDepositItem == true && playerScript.carryingItem == true && playerScript.carryingItem1 == true)
        {
            Instantiate(partPickup).transform.position = new Vector3(-10, -2.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem = false;
            playerScript.carryingItem1 = false;
            Debug.Log("you deposited up item");
        }
        if (Input.GetKeyDown(KeyCode.M) && canDepositItem == true && playerScript.carryingItem == true && playerScript.carryingItem2 == true)
        {
            Instantiate(partPickup2).transform.position = new Vector3(-9, -2.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem = false;
            playerScript.carryingItem2 = false;
            Debug.Log("you deposited up item");
        }
        if (Input.GetKeyDown(KeyCode.M) && canDepositItem == true && playerScript.carryingItem == true && playerScript.carryingItem3 == true)
        {
            Instantiate(partPickup3).transform.position = new Vector3(-10, -1.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem = false;
            playerScript.carryingItem3 = false;
            Debug.Log("you deposited up item");
        }
        if (Input.GetKeyDown(KeyCode.M) && canDepositItem == true && playerScript.carryingItem == true && playerScript.carryingItem4 == true)
        {
            Instantiate(partPickup4).transform.position = new Vector3(-9, -1.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem = false;
            playerScript.carryingItem4 = false;
            Debug.Log("you deposited up item");
        }
        if (Input.GetKeyDown(KeyCode.M) && canDepositItem == true && playerScript.carryingItem == true && playerScript.carryingItem5 == true)
        {
            Instantiate(partPickup5).transform.position = new Vector3(-10, -0.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem = false;
            playerScript.carryingItem5 = false;
            Debug.Log("you deposited up item");
        }
        if (Input.GetKeyDown(KeyCode.M) && canDepositItem == true && playerScript.carryingItem == true && playerScript.carryingItem6 == true)
        {
            Instantiate(partPickup6).transform.position = new Vector3(-9, -0.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem = false;
            playerScript.carryingItem6 = false;
            Debug.Log("you deposited up item");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Deposit")
        {
            canDeposit();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Deposit")
        {
            cantDeposit();
        }
    }
    public void canDeposit()
    {
        canDepositItem = true;
    }
    public void cantDeposit()
    {
        canDepositItem = false;

    }
}
