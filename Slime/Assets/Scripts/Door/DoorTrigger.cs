using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private DoorAnimated door;
    public Canvas interactUI;

    private void Start()
    {
        interactUI.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && door.doorIsOpen == false)
        {
            door.OpenDoor();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Door")
        {
            interactUI.enabled = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Door")
        {
            interactUI.enabled = false;
        }
    }

}

