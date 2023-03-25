using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Vector3 Velocity;
    public float MoveSpeed;
    public float CheckDistance;
    public LayerMask Wall;

    public int MaxHealth = 100;
    int currentHealth;
    public float health;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Velocity * MoveSpeed * Time.deltaTime;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Velocity, CheckDistance, Wall);

        if (hit != false)
        {
            Velocity *= -1;
        }

        {
            if (health <= 0)
            {
                Debug.Log("Enemy is dead");
                Destroy(gameObject);
            }
        }

    }
}
