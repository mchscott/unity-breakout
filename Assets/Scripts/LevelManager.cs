using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Block.breakableCount = 0;
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

    public void NextLevel()
    {
		Block.breakableCount = 0;
        Application.LoadLevel(Application.loadedLevel + 1);

    }
	public void BrickDestroyed()
	{
		if (Block.breakableCount <= 0) {

			Debug.Log ("Al bricks cleared");
			//levelManager.NextLevel ();
			NextLevel();
		}

	}
}
