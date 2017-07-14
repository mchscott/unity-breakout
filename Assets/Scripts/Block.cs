﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public int maxHits;
    public int timesHit;
    private LevelManager levelManager;
	// Use this for initialization
	void Start () {
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
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
            // SimulateWin();
        }
    }
    private void SimulateWin()
    {
        //SimulateWin();
        levelManager.NextLevel();
    }
}
