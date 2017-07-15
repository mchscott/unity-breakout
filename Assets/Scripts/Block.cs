using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public int maxHits;
    public int timesHit;
	public AudioClip crack;

	public static int breakableCount = 0;
    private LevelManager levelManager;
	private bool isBreakable = false;

	// Use this for initialization
	void Start () {
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
		if (this.tag == "Breakable") {
			isBreakable = true;
		}
		// keep track of breakable bricks
		if (isBreakable) {
			breakableCount = breakableCount + 1;
				print( breakableCount);
		}
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
		AudioSource.PlayClipAtPoint (crack, transform.position, 0.3f);
        timesHit++;
        if ( timesHit>=maxHits)
        {
			breakableCount--;
			// Debug.Log ( breakableCount.ToString);
			levelManager.BrickDestroyed ();
			Destroy(gameObject);
        }
    }

    private void SimulateWin()
    {
        //SimulateWin();
        levelManager.NextLevel();
    }
}
