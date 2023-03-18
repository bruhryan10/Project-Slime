using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairwellScript : MonoBehaviour
{

    public bool canGoDownStairs;
    public bool canGoUpStairs;
    public GameObject Player;
    void Start()
    {
        
    }

    void Update()
    {

        if (canGoDownStairs == true && Input.GetKeyDown(KeyCode.L))
        {
            float x = Player.transform.position.x;
            float y = Player.transform.position.y;
            Player.transform.position = new Vector2(x, y + -25);
        }
        if (canGoUpStairs == true && Input.GetKeyDown(KeyCode.L))
        {
            float x = Player.transform.position.x;
            float y = Player.transform.position.y;
            Player.transform.position = new Vector2(x, y + 25);
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
            canGoDown();
            //Debug.Log("can go down");
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "StairsUp")
        {
            canGoUp();
            //Debug.Log("can go up");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "StairsDown")
        {
            cantGoDown();
            //Debug.Log("cant go down");
        }
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "StairsUp")
        {
            cantGoUp();
            //Debug.Log("cant go up");
        }
    }
}
