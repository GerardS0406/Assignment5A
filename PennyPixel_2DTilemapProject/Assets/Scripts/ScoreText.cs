using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public int score;
    private Text textBox;
    // Start is called before the first frame update
    void Start()
    {
        textBox = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = "Score: " + score;
    }
}
