/*
* Gerard Lamoureux
* 5A
* Handles when player goes too low so game ends.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooLowEndGame : MonoBehaviour
{
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < -10)
        {
            Debug.Log(gameObject.transform.position.y);
            text.GetComponent<WinManager>().gameOver = true;
        }
    }
}
