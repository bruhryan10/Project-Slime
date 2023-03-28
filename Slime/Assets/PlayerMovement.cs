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

    Vector3 Velocity;

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

        Velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            playerAnim.Play("Move_Up");
            Velocity += Vector3.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            playerAnim.Play("Move_Down");
            Velocity += Vector3.down;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerAnim.Play("Move_Right");
            Velocity += Vector3.right;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            playerAnim.Play("Move_Left");
            Velocity += Vector3.left;
        }

        Velocity *= moveSpeed;

        transform.position += Velocity * Time.deltaTime;



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
