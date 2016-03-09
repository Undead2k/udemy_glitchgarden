using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		print (PlayerPrefManager.GetMasterVolume ());
		PlayerPrefManager.SetMasterVolume (0.2f);
		print (PlayerPrefManager.GetMasterVolume ());

		print (PlayerPrefManager.IsLevelUnlocked (3));
		PlayerPrefManager.SetLevelUnlock (3);
		print (PlayerPrefManager.IsLevelUnlocked (3));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
