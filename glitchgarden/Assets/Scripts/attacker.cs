using UnityEngine;
using System.Collections;

public class attacker : MonoBehaviour {

	[Range(-5f, 5f)]
	public float walkSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * walkSpeed * Time.deltaTime);
	}
}
