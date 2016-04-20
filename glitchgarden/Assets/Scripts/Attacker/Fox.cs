using UnityEngine;
using System.Collections;

public class Fox : MonoBehaviour {

	private attacker attacker;

	// Use this for initialization
	void Start () {

		attacker = GameObject.FindObjectOfType<attacker>;

	}
	
	// Update is called once per frame
	void Update () {
	 
	}

	void OnTriggerEnter2D(Collider2D wall){
		if (wall.gameObject.tag == "wall") {
			Debug.Log ("wall");
		}
	}

}
