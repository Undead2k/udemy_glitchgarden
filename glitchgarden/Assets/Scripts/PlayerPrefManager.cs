﻿using UnityEngine;
using System.Collections;

public class PlayerPrefManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";
		//level_unlocked_1 


	public static void SetMasterVolume (float volume) {
		if (volume >= 0.0f && volume <= 1.0f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError("Master volume out of range");
		}
	}

	public static float GetMasterVolume(){
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}


	public static void SetLevelUnlock(int level){
		if(level <= Application.levelCount -1){
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString(), 1); // use 1 for true, as we cant use BOOL
		} else {
			Debug.LogError("Trying to unlock level not in build order");
		}
	}

	public static bool GetLevelUnlocked (int level) {
		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
		bool isLevelUnlocked = (levelValue == 1);

		if (level <= Application.levelCount - 1) {
			return isLevelUnlocked;
		} else {
			Debug.LogError("Trying to query level not in build order");
			return false;
		} 
	}


	public static void SetDifficulty (float difficulty) {
		if (difficulty >= 1f && difficulty <= 3f) {
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError("Out of Difficulty Range");
		}
	}

	public static float GetDifficulty (){
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}

}
