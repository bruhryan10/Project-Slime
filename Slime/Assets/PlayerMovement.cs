using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;

    public Vector3 moveDir;

    public float moveSpeed = 6.5f;
    ColdScript coldScript;
    PlayerScript playerScript;


    public Animator playerAnim;

    private void Awake()
    {
        coldScript = GameObject.Find("Frozen Area").GetComponent<ColdScript>();
        rigidBody2D= GetComponent<Rigidbody2D>();
        playerScript = GameObject.Find("Player").GetComponent<PlayerScript>();
    }

    private void Update()
    {
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 10);
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = +1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = +1f;
        }
        
        moveDir = new Vector3(moveX, moveY).normalized;

        if (coldScript.slowedMovement == true)
        {
            moveSpeed = 5f;
        }
        if (coldScript.slowedMovement == false)
        {
            moveSpeed = 6.5f;
        }
        if (playerScript.lightStatus == true)
        {
            moveSpeed = 12f;
        }
        if (playerScript.lightStatus == false && coldScript.slowedMovement == false)
        {
            moveSpeed = 6.5f;
        }
    }

    private void FixedUpdate()
    {
        rigidBody2D.velocity = moveDir * moveSpeed;
    }
}
