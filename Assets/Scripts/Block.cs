using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public int maxHits;
    public int timesHit;
	// Use this for initialization
	void Start () {
        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void updateColor()
    {
       // gameObject.
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        if ( timesHit>=maxHits)
        {
            Destroy(gameObject);
        }
    }
}
