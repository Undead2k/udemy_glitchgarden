using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class action_fade : MonoBehaviour {

	public float fade;

	private Image fadePanel;
	private Color currentColour = Color.black;
	private float alphaStart;

	public float delay;

	public bool b_fadeOut;
	public bool b_fadeIn;

	// Use this for initialization
	void Start () {
		//gets access to componet features so we can manipulate things later
		fadePanel = GetComponent<Image>();

		//sets the alpha at start
		if (b_fadeOut){
			alphaStart = 1.0f;
			currentColour.a = alphaStart;
		} 

		if (b_fadeIn) {
			alphaStart = 0.0f;
			currentColour.a = alphaStart;
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (b_fadeOut){
			fadeOut();
		} 

		if(b_fadeIn){

			//if 0 delay, it just fades in as normal. 
			//add a delay and it will pause before fading in.
			StartCoroutine(startDelay());

			//fadeIn();
		}


		if (b_fadeOut && b_fadeIn){
			Debug.Log("This will do nothing. Set only Fade in or Fade out!");
		} 

	}

	void fadeOut(){
		if (Time.timeSinceLevelLoad < fade){
			float alphaChange = Time.deltaTime / fade;
			currentColour.a -= alphaChange;
			fadePanel.color = currentColour;
		} else {
			gameObject.SetActive (false);
		}
	}
	
	void fadeIn(){
		//if (Time.timeSinceLevelLoad < fade){
		float alphaChange = Time.deltaTime / fade;
		currentColour.a += alphaChange;
		fadePanel.color = currentColour;
		//} 
	}


	IEnumerator startDelay(){

		yield return new WaitForSeconds(delay);

		fadeIn ();
	}



}
