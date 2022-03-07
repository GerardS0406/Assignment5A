/*
* Gerard Lamoureux
* 5A
* Handles Game Over Text
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    public bool gameOver = false;
    public bool win = false;
    private Text textbox;
    private IEnumerator coroutine;
    // Start is called before the first frame update
    void Start()
    {
        textbox = gameObject.GetComponent<Text>();
        StartCoroutine("ShowTutorial");
    }

    private IEnumerator ShowTutorial()
    {
        textbox.enabled = true;
        textbox.text = "Collect All 10 Gems\nFind the Opened Gate to Win!";
        yield return new WaitForSeconds(5);
        textbox.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            textbox.enabled = true;
            if (win)
                textbox.text = "Game Over!\nYou Win!\nPress R to try again!";
            else
                textbox.text = "Game Over!\nYou Lose!\nPress R to try again!";
            if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
