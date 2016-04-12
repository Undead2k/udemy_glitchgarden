using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SetStartVolumne : MonoBehaviour {

	private MusicManager musicManager;
	private float masterVolume;

	// Use this for initialization
	void Start () {
	
		musicManager = GameObject.FindObjectOfType<MusicManager> ();
		masterVolume = PlayerPrefManager.GetMasterVolume ();


	}
	
	// Update is called once per frame
	void Update () {
		musicManager.ChangeVolume (masterVolume);


	}
}
