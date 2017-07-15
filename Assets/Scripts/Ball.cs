using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Ball : MonoBehaviour {


    private Paddle paddle;
    private Vector3 paddleToBallVector;
    private Rigidbody2D rigi;
    private bool launched = false;
	private AudioSource audio;
	// Use this for initialization
	void Start () {
        paddle = FindObjectOfType<Paddle>();
        rigi = GetComponent<Rigidbody2D>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
		audio = GetComponent<AudioSource>();
		audio.volume = 0.05f;
		//
		//audio.Play(44100);
	}
	
	// Update is called once per frame
	void Update () {
        if ( launched == false )
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;
        }
        

        if (Input.GetMouseButtonDown(0))
        {   
            //this.GetComponent.velocity = new Vector2(2f, 10f);
            //this.rigidbody2D.velocity = new Vector2(2f, 10f);
			if (!launched) {
				rigi.velocity = new Vector2 (2.5f, 16f);
				launched = true;
			}
				
        }
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (launched) {
			audio.volume = 0.1f;
			audio.Play();
		}
	}
}
