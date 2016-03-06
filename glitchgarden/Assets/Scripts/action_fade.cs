using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class action_fade : MonoBehaviour {

	public float fadeInTime;

	private Image fadePanel;
	private Color currentColour = Color.black;



	// Use this for initialization
	void Start () {
		fadePanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad < fadeInTime){
			//fadein
		} else {
			gameObject.SetActive (false);
		}

	}
}
