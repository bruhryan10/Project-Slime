using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AiDetect : MonoBehaviour
{
    public float speed;
    public float FollowingDistance;
    public float RetreatDistance;

    private Transform target;
    private bool playerDetected;


    public GameObject player;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerDetected = false;
    }

    void Update()
    {
        if (!playerDetected && Vector2.Distance(transform.position, target.position) <= FollowingDistance)
        {
            playerDetected = true;
        }

        if (playerDetected)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        if (Vector2.Distance(transform.position, target.position) > RetreatDistance)
        {
            playerDetected = false;
        }
    }

    private void AIUpdate()
    {
        Vector3 scale = transform.localScale;
        if (player.transform.position.x > transform.position.x)
            scale.x = Mathf.Abs(scale.x) * -1;
        else
        {
            scale.x = Mathf.Abs(scale.x);
        }
    }
}
