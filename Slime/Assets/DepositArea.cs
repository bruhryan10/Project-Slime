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
        if (Input.GetKeyDown(KeyCode.M) && canDepositItem == true && playerScript.carryingItem1 == true)
        {
            Instantiate(partPickup).transform.position = new Vector3(-10, -2.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem1 = false;
        }
        if (Input.GetKeyDown(KeyCode.M) && canDepositItem == true && playerScript.carryingItem2 == true)
        {
            Instantiate(partPickup2).transform.position = new Vector3(-9, -2.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem2 = false;
        }
        if (Input.GetKeyDown(KeyCode.M) && canDepositItem == true && playerScript.carryingItem3 == true)
        {
            Instantiate(partPickup3).transform.position = new Vector3(-10, -1.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem3 = false;
        }
        if (Input.GetKeyDown(KeyCode.M) && canDepositItem == true && playerScript.carryingItem4 == true)
        {
            Instantiate(partPickup4).transform.position = new Vector3(-9, -1.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem4 = false;
        }
        if (Input.GetKeyDown(KeyCode.M) && canDepositItem == true && playerScript.carryingItem5 == true)
        {
            Instantiate(partPickup5).transform.position = new Vector3(-10, -0.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem5 = false;
        }
        if (Input.GetKeyDown(KeyCode.M) && canDepositItem == true && playerScript.carryingItem6 == true)
        {
            Instantiate(partPickup6).transform.position = new Vector3(-9, -0.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem6 = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Deposit")
        {
            canDepositItem = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Deposit")
        {
            canDepositItem = false;
        }
    }
}
