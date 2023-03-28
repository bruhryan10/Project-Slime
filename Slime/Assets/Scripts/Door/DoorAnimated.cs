using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimated : MonoBehaviour
{
    private Animator animator;
    public bool doorIsOpen;
    public float doorTimer = 2f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void Update()
    {
        if (doorIsOpen == true)
        {
            doorTimer -= Time.deltaTime;
            if (doorTimer <= 0)
            {
                CloseDoor();
            }
        }
        
    }
    public void OpenDoor()
    {
        doorIsOpen = true;
        animator.SetBool("Open", true);
        
    }

    public void CloseDoor()
    {
        doorIsOpen = false;
        doorTimer = 2f;
        animator.SetBool("Open", false);
        

    }

}
