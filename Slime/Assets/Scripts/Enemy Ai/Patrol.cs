using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float StartWaitTime;
    private float WaitTime;

    public Transform[] MoveSpots;
    private int RandomSpot;


    private void Start()
    {
        WaitTime = StartWaitTime;
        RandomSpot = Random.Range(0, MoveSpots.Length);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, MoveSpots[RandomSpot].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, MoveSpots[RandomSpot].position) <0.2f)
            if (WaitTime <= 0)
            {
                RandomSpot = Random.Range(0, MoveSpots.Length);
                WaitTime = StartWaitTime;
            }
        else
        {
            WaitTime -= Time.deltaTime;
        }
        

    }

}
