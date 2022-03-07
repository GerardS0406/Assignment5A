/*
* Gerard Lamoureux
* 5A
* Handles Game Over Text
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinManager : MonoBehaviour
{
    public bool gameOver = false;
    private Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        textbox = gameObject.GetComponent<Text>();
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == true)
        {
            gameObject.SetActive(true);
            textbox.text = "Game Over!\nYou Win!";
        }
    }
}
