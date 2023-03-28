using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class InteractCrate : MonoBehaviour
{
    public Canvas interactUI;
    public bool canOpenCrate;
    public GameObject OpenCrate;
    public bool canOpenTheCrate;
    public GameObject PartDrop;

    void Start()
    {
        interactUI.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canOpenCrate == true)
        {
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.F) && canOpenTheCrate == true)
        {
            PartDrop.transform.position = new Vector2(-72.65f, -93.34f);
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Crate")
        {
            interactUI.enabled = true;
            canOpenCrate = true;
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "TheCrate")
        {
            interactUI.enabled = true;
            canOpenTheCrate = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Crate")
        {
            interactUI.enabled = false;
            canOpenCrate = false;
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "TheCrate")
        {
            interactUI.enabled = false;
            canOpenTheCrate = false;
        }
    }
    private void OnDestroy()
    {
        Instantiate(OpenCrate, transform.position, Quaternion.identity);
    }
}
