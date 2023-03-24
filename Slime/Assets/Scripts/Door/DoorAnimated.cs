using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimated : MonoBehaviour
{
    private Animator animator;
    public GameObject doorCollision;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void OpenDoor()
    {
        animator.SetBool("Open", true);
        doorCollision.SetActive(false);
    }

    public void CloseDoor()
    {
        animator.SetBool("Open", false);
        doorCollision.SetActive(true);

    }
}
