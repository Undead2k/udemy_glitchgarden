using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;

	void Start () {
		if (autoLoadNextLevelAfter == 0){
		
		}

		else {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);

		}
	}

	public void LoadLevel(string name){
		print("Level load requested for: "+name);
		Application.LoadLevel(name);
	
	}
	
	public void QuitRequest(){
		print("quit request");
		Application.Quit();
	}
	
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
	}

}
