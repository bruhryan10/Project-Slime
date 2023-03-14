using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    ColdScript coldScript;
    public float PlayerHealth = 10f;


    // Start is called before the first frame update
    void Start()
    {
        coldScript = GameObject.Find("Frozen Area").GetComponent<ColdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("Labratory");
        }
    }

    public void minusHealth()
    {
        PlayerHealth -= 1f;
    }
    public void playerDeath()
    {

    }
}
