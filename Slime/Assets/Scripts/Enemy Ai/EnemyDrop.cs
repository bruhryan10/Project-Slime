using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    public GameObject itemToDrop; 

    private bool hasDroppedItem = false; 

    private void OnDestroy()
    {
       
        if (!hasDroppedItem)
        {
            
            Instantiate(itemToDrop, transform.position, Quaternion.identity);
            hasDroppedItem = true;
        }
    }
}
