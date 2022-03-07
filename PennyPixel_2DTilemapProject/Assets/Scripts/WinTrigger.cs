/*
* Gerard Lamoureux
* 5A
* Handles Win Trigger
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            text.GetComponent<WinManager>().win = true;
            text.GetComponent<WinManager>().gameOver = true;
            Debug.Log("Hello");
        }
    }
}
