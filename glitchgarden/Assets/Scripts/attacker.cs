using UnityEngine;
using System.Collections;

public class attacker : MonoBehaviour {

	[Range(-5f, 5f)]
	public float currentSpeed;

	// Use this for initialization
	void Start () {
		Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D> ();
		myRigidBody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);
	}

	public void SetSpeed (float speed) {
		currentSpeed = speed;
	}

	public void AttackCurrentTarget (float damage){
		Debug.Log (name + " attacking");
	}
}
