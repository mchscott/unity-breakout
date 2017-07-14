using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Paddle paddle;
    private Vector3 paddleToBallVector;
    private Rigidbody2D rigi;
    private bool launched = false;
	// Use this for initialization
	void Start () {
        rigi = GetComponent<Rigidbody2D>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if ( launched == false )
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;
        }
        

        if (Input.GetMouseButtonDown(0))
        {
            print("Mouse clicked");
            launched = true;
            //this.GetComponent.velocity = new Vector2(2f, 10f);
            //this.rigidbody2D.velocity = new Vector2(2f, 10f);
            rigi.velocity = new Vector2(2.5f, 16f);
        }
	}
}
