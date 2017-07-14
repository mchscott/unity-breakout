using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * paddle x pos from 82 -> 97
 * */
public class Paddle : MonoBehaviour {
    private float mousePosInBlocks;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosXRatioOfScreen = Input.mousePosition.x / Screen.width;
//        float paddlePosInBlocks = (this.transform.position.x - 82) / 15 * 16;
        // if (  )
        //Debug.Log("paddle pos = " + ( this.transform.position.x - 82) /15 * 16 );
        Vector3 paddPos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

        /*
        if ( mousePosInBlocks < paddlePosInBlocks )
        {
            paddPos = new Vector3( Mathf.Clamp(this.transform.position.x - 0.1f,82f,97f), this.transform.position.y, this.transform.position.z);
        } else if (mousePosInBlocks > paddlePosInBlocks )
        {
            paddPos = new Vector3(Mathf.Clamp( this.transform.position.x + 0.1f,82f, 97f), this.transform.position.y, this.transform.position.z);
        }
        */


        paddPos = new Vector3(Mathf.Clamp(mousePosInBlocks+82f, 82f, 97f), this.transform.position.y, this.transform.position.z);
        //Debug.Log(mousePosInBlocks);
        //        Debug.Log(Input.mousePosition.x / Screen.width);
        //  Debug.Log("Mouse Moved");
        this.transform.position = paddPos;
	}
}
