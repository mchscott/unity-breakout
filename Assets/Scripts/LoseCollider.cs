using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    public LevelManager levelManger;

     void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger");
        levelManger.LoadLevel("Win Screen");
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collission ");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
