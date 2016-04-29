using UnityEngine;
using System.Collections;

public class attacker : MonoBehaviour {


	private float currentSpeed;
	private GameObject currentTarget;

	private Animator anim;
	private health health;

	// Use this for initialization
	void Start () {
		Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D> ();
		myRigidBody.isKinematic = true;

		anim = GetComponent<Animator> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);

		if (!currentTarget) {
			Walk();
		}
	}

	// actions 

	public void SetSpeed (float speed) {
		currentSpeed = speed;
	}

	public void StrikeCurrentTarget(float damage){
		if (currentTarget) {
			health = currentTarget.GetComponent<health> ();
			if (health){
				health.TakeDamage(damage);
			}
		}


		Debug.Log ("attacking: " + damage + " being dealt to " + currentTarget);
	}
	
	public void Attack (GameObject obj){

		currentTarget = obj;


		Debug.Log ("starting attacking");
		anim.SetBool ("isAttacking", true);


	}

	public void Walk (){
		Debug.Log ("walking");
		anim.SetBool ("isAttacking", false);
	}

	public void Jump(){
		Debug.Log ("jumping");
		anim.SetTrigger ("isJumping");
	}
}
