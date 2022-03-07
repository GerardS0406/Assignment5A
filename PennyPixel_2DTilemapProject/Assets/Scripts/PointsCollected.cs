/*
* Gerard Lamoureux
* 5A
* Handles Deleting the Gate to win
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCollected : MonoBehaviour
{
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreText.GetComponent<ScoreText>().score >= 10)
        {
            gameObject.SetActive(false);
        }
    }
}
