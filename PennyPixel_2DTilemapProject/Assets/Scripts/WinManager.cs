using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinManager : MonoBehaviour
{
    public bool gameOver = false;
    public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
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
