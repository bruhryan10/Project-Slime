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



    public Transform attackPoint;
    public float radius;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public float damage;

    void Start()
    {

    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
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
}
