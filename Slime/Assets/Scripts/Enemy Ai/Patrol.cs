using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float waitTime;
    public Transform[] moveSpots;

    private int currentSpotIndex;
    private float waitTimer;

    void Start()
    {
        currentSpotIndex = 0;
        waitTimer = 0f;
    }

    void Update()
    {
        Transform currentSpot = moveSpots[currentSpotIndex];

        if (Vector2.Distance(transform.position, currentSpot.position) < 0.1f)
        {
            waitTimer += Time.deltaTime;
            if (waitTimer >= waitTime)
            {
                currentSpotIndex++;
                if (currentSpotIndex >= moveSpots.Length)
                {
                    currentSpotIndex = 0;
                }
                waitTimer = 0f;
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, currentSpot.position, speed * Time.deltaTime);
        }
    }
}
