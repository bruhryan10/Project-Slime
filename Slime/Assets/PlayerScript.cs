using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    ColdScript coldScript;
    public LayerMask wall;
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

    public bool isDead;
    public bool carryingKey;
    public bool carryingCrowbar;
    public bool carryingKeyCard;
    public float lightTimer = 10f;


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
                lightTimer = 10f;
            }
        }
        if (PlayerHealth <= 0)
        {
            isDead = true;
        }
    }

    public void minusHealth()
    {
        PlayerHealth -= 1f;
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
