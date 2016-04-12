using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider diffSlider;
	public LevelManager levelManager;

	private MusicManager musicManager;
	private Text diffTxt;
	private Text volTxt;

	private string percentage = "%";

	private float volumeDisplayName;



	Dictionary<float, string> myDic = new Dictionary<float, string> ();

	// Use this for initialization
	void Start () {

		myDic.Add (1, "Easy");
		myDic.Add (2, "Normal");
		myDic.Add (3, "Hard");

		musicManager = GameObject.FindObjectOfType<MusicManager> ();
		diffTxt = GameObject.Find ("DiffTxt").GetComponent<Text> ();
		volTxt = GameObject.Find ("VolTxt").GetComponent<Text> ();

		volumeSlider.value = PlayerPrefManager.GetMasterVolume ();
		diffSlider.value = PlayerPrefManager.GetDifficulty ();
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.ChangeVolume (volumeSlider.value);

		volumeDisplayName = (volumeSlider.value) * 100;
		volTxt.text = Mathf.Ceil (volumeDisplayName).ToString ()+percentage;

		// updates text when changing difficulty
		if (myDic.ContainsKey (diffSlider.value)) {
			string value = myDic[diffSlider.value];
			diffTxt.text = value;
		}
	}

	public void DefaultSettings(){
		volumeSlider.value = 0.5f;
		diffSlider.value = 2f;
	}

	public void SaveAndExit(){
		PlayerPrefManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefManager.SetDifficulty (diffSlider.value);
		levelManager.LoadLevel ("01_Start");
	}



}
