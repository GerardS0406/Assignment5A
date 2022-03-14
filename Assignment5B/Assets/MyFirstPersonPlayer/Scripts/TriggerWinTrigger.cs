/*
* Gerard Lamoureux
* 5B
* Handles Win Trigger
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerWinTrigger : MonoBehaviour
{
    private ScoreManager sm;
    private Text gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("/Canvas/ScoreText").GetComponent<ScoreManager>();
        gameOverText = GameObject.Find("/Canvas/WinText").GetComponent<Text>();
        gameOverText.text = "";
    }
    void OnTriggerEnter(Collider theCollider)
    {
        if (theCollider.CompareTag ("Player") && sm.score >= 6) {
            gameOverText.text = "Game Over! You Win!";
            Destroy(gameObject);
        }
    }
}
