using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;

    private Transform target;

    public float StoppingDistance;

    public float RetreatDistance;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > StoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        else if (Vector2.Distance(transform.position, target.position) < StoppingDistance && Vector2.Distance(transform.position, target.position) > RetreatDistance)
        {
            transform.position = this.transform.position; 
        }
        else if (Vector2.Distance(transform.position, target.position) < RetreatDistance) 
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);
        }
    }

    
}
