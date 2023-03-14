using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuclearScript : MonoBehaviour
{
    public bool WasteDamage;
    PlayerScript playerScript;
    public float damageTimer = 10f;

    void Start()
    {
         playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();       
    }

    void Update()
    {
        if (WasteDamage == true)
        {
            damageTimer -= Time.deltaTime;
            if (damageTimer < 0)
            {
                playerScript.minusHealth();
                damageTimer = 10f;
            }
            if (playerScript.PlayerHealth == 0)
            {
                //run death code here
                Debug.Log("you died");
            }
            Debug.Log("taking damage");
        }
    }



    public void startDamage()
    {
        WasteDamage = true;
    }
    public void endDamage()
    {
        WasteDamage = false;
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Waste")
        {
            startDamage();
            Debug.Log("enter");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.gameObject.tag == "Waste")
        {
            endDamage();
            Debug.Log("Exit");
        }
    }
}
