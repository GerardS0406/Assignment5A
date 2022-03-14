using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCoin : MonoBehaviour
{
    private ScoreManager sm;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("/Canvas/ScoreText").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0,1,0);
    }

    void OnTriggerEnter(Collider theCollider)
    {
        if (theCollider.CompareTag ("Player")) {
            sm.score++;
            Destroy(gameObject);
        }
    }
}
