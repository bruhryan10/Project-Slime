using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    public GameObject CrowbarDrop;
    public GameObject KeyDrop;
    public GameObject KeyCardDrop;
    PlayerScript playerScript;
    EnemyHealth enemyHealth;
    public float dropChance;

    private void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
        enemyHealth = GameObject.Find("Enemy Ai").GetComponent<EnemyHealth>();

    }

    private void OnDestroy()
    {
        dropChance = Random.Range(1, 5);
        if (dropChance == 1 && playerScript.carryingCrowbar == false)
        {
            //Debug.Log("cool");
            CrowbarDrop.transform.position = enemyHealth.lastLoc;
        }
        if (dropChance == 2 && playerScript.carryingKey == false)
        {
            //Debug.Log("cool");
            KeyDrop.transform.position = enemyHealth.lastLoc;
        }
        if (dropChance == 3 && playerScript.carryingKeyCard == false)
        {
            //Debug.Log("cool");
            KeyCardDrop.transform.position = enemyHealth.lastLoc;
        }
    }
}
