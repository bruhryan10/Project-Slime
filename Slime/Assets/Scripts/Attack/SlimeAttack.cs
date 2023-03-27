using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeAttack : MonoBehaviour
{
    public Animator weaponAnim;
    private float attackTimer = 0;
    public float attackTotalTime = 0;
    bool Sword_Attack;
    public float timer;
    private bool attack;
    PlayerScript playerScript;



    public Transform attackPoint;
    public float radius;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public float damage;

    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();

    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && playerScript.heavyStatus == false)
        {
            weaponAnim.SetBool("Sword_Attack", true);
        }
        else
        {
            weaponAnim.SetBool("Sword_Attack", false);
        }

    }

    void CheckMeleeAttacking()
    {



    }

    bool CanAttack()
    {
        if (attackTimer > attackTotalTime)
        {
            attackTimer = 0;
            weaponAnim.SetBool("Sword_Attack", false);
            return true;
        }
        attackTimer += Time.deltaTime;
        return false;
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(attackPoint.transform.position, radius);
    }


    void Attacking()
    {
        Collider2D[] slime = Physics2D.OverlapCircleAll(attackPoint.transform.position, radius, enemyLayers);

        foreach (Collider2D enemyGameObject in slime)
        {
            Debug.Log("Hit enemy");
            enemyGameObject.GetComponent<EnemyHealth>().health -= damage;
        }
    }
}
