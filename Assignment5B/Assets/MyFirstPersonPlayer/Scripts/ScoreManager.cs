using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    private Text textbox;
    private Text gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        textbox = gameObject.GetComponent<Text>();
        gameOverText = GameObject.Find("/Canvas/WinText").GetComponent<Text>();
        gameOverText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Pages: " + score;
        if(score >= 6)
            gameOverText.text = "Game Over! You Win!";

    }
}
