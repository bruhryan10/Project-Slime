using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float detectionRange = 5f;
    public Transform target;
    private Rigidbody2D rb2d;
    private bool isFollowing = false;


    public LayerMask Wall;
    public int MaxHealth = 100;
    int currentHealth;





    public float StoppingDistance;
    public float RetreatDistance;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        Vector2 movement = Vector2.zero;
        if (isFollowing && target != null)
        {
            movement = target.position - new Vector3(rb2d.position.x, rb2d.position.y, 0);
        }

        rb2d.velocity = movement.normalized * moveSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isFollowing = true;
            target = other.transform;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isFollowing = false;
            target = null;
        }
    }


   

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }

    
    
   


   
}
