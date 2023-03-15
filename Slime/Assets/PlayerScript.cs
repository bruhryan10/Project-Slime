using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    ColdScript coldScript;
    public float PlayerHealth = 10f;
    public bool heavyStatus;
    public bool lightStatus;
    public bool carryingItem;
    public float lightTimer = 5f;


    // Start is called before the first frame update
    void Start()
    {
        coldScript = GameObject.Find("Frozen Area").GetComponent<ColdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("Labratory");
        }
        if (lightStatus == true)
        {
            lightTimer -= Time.deltaTime;
            if (lightTimer < 0)
            {
                lightStatus = false;
                lightTimer = 5f;
            }
        }
        if (heavyStatus == true)
        {
            //cant attack or whatever debuff code goes here
        }
    }

    public void minusHealth()
    {
        PlayerHealth -= 1f;
    }
    public void playerDeath()
    {

    }
    public void hasItem()
    {
        heavyStatus = true;
        carryingItem = true;
    }
    public void lightStatusEffect()
    {
        lightStatus = true;

    }
}
