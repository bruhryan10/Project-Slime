using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class StairwellScript : MonoBehaviour
{
    public Canvas interactUI;
    public bool canGoDownStairs;
    public bool canGoUpStairs;
    public GameObject Player;
    void Start()
    {
        interactUI.enabled = false;
    }

    void Update()
    {

        if (canGoDownStairs == true && Input.GetKeyDown(KeyCode.F))
        {
            float x = Player.transform.position.x;
            float y = Player.transform.position.y;
            Player.transform.position = new Vector2(x, y + -104);
        }
        if (canGoUpStairs == true && Input.GetKeyDown(KeyCode.F))
        {
            float x = Player.transform.position.x;
            float y = Player.transform.position.y;
            Player.transform.position = new Vector2(x, y + 104);
        }

    }

    public void canGoDown()
    {
        canGoDownStairs = true;
    }
    public void cantGoDown()
    {
        canGoDownStairs = false;
    }
    public void canGoUp()
    {
        canGoUpStairs = true;
    }
    public void cantGoUp()
    {
        canGoUpStairs = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "StairsDown")
        {
            interactUI.enabled = true;
            canGoDown();
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "StairsUp")
        {
            interactUI.enabled = true;
            canGoUp();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "StairsDown")
        {
            interactUI.enabled = false;
            cantGoDown();
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "StairsUp")
        {
            interactUI.enabled = false;
            cantGoUp();
        }
    }
}
