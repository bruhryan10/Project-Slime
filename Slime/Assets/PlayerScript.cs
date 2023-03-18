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
    public bool carryingItem1;
    public bool carryingItem2;
    public bool carryingItem3;
    public bool carryingItem4;
    public bool carryingItem5;
    public bool carryingItem6;

    public bool carryingKey;
    public float lightTimer = 5f;


    void Start()
    {
        coldScript = GameObject.Find("Frozen Area").GetComponent<ColdScript>();
    }

    void Update()
    {
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
    public void hasItem1()
    {
        heavyStatus = true;
        carryingItem1 = true;
        carryingItem = true;
    }
    public void hasItem2()
    {
        heavyStatus = true;
        carryingItem2 = true;
        carryingItem = true;
    }
    public void hasItem3()
    {
        heavyStatus = true;
        carryingItem3 = true;
        carryingItem = true;
    }
    public void hasItem4()
    {
        heavyStatus = true;
        carryingItem4 = true;
        carryingItem = true;
    }
    public void hasItem5()
    {
        heavyStatus = true;
        carryingItem5 = true;
        carryingItem = true;
    }
    public void hasItem6()
    {
        heavyStatus = true;
        carryingItem6 = true;
        carryingItem = true;
    }
    public void lightStatusEffect()
    {
        lightStatus = true;

    }
}
