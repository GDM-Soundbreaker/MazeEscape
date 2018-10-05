using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour {

    public Score scoreTracker;
    public int scoreValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ///only if player hits
        if (collision.GetComponent <Player>())
        {
            //updating the score based on how much item is worth
            scoreTracker.ChangeValue(scoreValue);

            //get rid of used item
            Destroy(gameObject);
        }
    }

}
