using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class InteractScript : MonoBehaviour
{
    public Canvas interactUI;
    public bool canOpenLocker;
    public bool canOpenPart;
    public GameObject OpenLocker;
    PlayerScript playerScript;
    public GameObject PartDrop;
    void Start()
    {
        interactUI.enabled = false;
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canOpenLocker == true)
        {
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.F) && canOpenPart == true)
        {
            PartDrop.transform.position = new Vector2(0.23f, 24.57f);
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Locker" && playerScript.carryingKey == true)
        {
            interactUI.enabled = true;
            canOpenLocker = true;
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "TheLocker" && playerScript.carryingKey == true)
        {
            interactUI.enabled = true;
            canOpenPart = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Locker")
        {
            interactUI.enabled = false;
            canOpenLocker = false;
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "TheLocker")
        {
            interactUI.enabled = false;
            canOpenPart = false;
        }
    }
    private void OnDestroy()
    {
        Instantiate(OpenLocker, transform.position, Quaternion.identity);
    }
}
