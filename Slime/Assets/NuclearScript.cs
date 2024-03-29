using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuclearScript : MonoBehaviour
{
    public bool wasteDamage;
    PlayerScript playerScript;
    public float damageTimer = 1f;

    void Start()
    {
         playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();       
    }

    void Update()
    {
        if (wasteDamage == true)
        {
            damageTimer -= Time.deltaTime;
            if (damageTimer < 0)
            {
                playerScript.minusHealth();
                damageTimer = 1f;
            }
            //Debug.Log("taking damage");
        }
    }



    public void startDamage()
    {
        wasteDamage = true;
    }
    public void endDamage()
    {
        wasteDamage = false;
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
