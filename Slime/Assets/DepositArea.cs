using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositArea : MonoBehaviour
{
    public bool canDepositItem;
    PlayerScript playerScript;
    public GameObject partPickup;
    public float itemsDeposited = 0;
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && itemsDeposited == 0 && canDepositItem == true && playerScript.carryingItem == true)
        {
            itemsDeposited = 1;
            //Debug.Log(itemsDeposited);
            Instantiate(partPickup).transform.position = new Vector3(-9, -1.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem = false;
            Debug.Log("you deposited up item");
        }
        if (Input.GetKeyDown(KeyCode.M) && itemsDeposited == 1 && canDepositItem == true && playerScript.carryingItem == true)
        {
            itemsDeposited = 2;
            Instantiate(partPickup).transform.position = new Vector3(-10, -2.5f);
            playerScript.heavyStatus = false;
            playerScript.lightStatusEffect();
            playerScript.carryingItem = false;
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
