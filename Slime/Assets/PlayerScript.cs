using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Vector3 Velocity;
    public float playerSpeed = 4;
    ColdScript coldScript;


    // Start is called before the first frame update
    void Start()
    {
        coldScript = GameObject.Find("Frozen Area").GetComponent<ColdScript>();
    }

    // Update is called once per frame
    void Update()
    {
       Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 10);
       Velocity = Vector3.zero;
        //movement
        if (Input.GetKey(KeyCode.W))
        {
            //playerAnim.Play("");
            Velocity += Vector3.up;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //playerAnim.Play("");
            Velocity += Vector3.left;

        }
        else if (Input.GetKey(KeyCode.S))
        {
            //playerAnim.Play("");
            Velocity += Vector3.down;

        }
        else if (Input.GetKey(KeyCode.D))
        {
            //playerAnim.Play("");
            Velocity += Vector3.right;

        }

        Velocity *= playerSpeed;

        transform.position += Velocity * Time.deltaTime;



        if (coldScript.slowedMovement == true)
        {
            playerSpeed = 2;
        }
        if (coldScript.slowedMovement == false)
        {
            playerSpeed = 4;
        }
    }
}
