using UnityEngine;
using System.Collections;

[RequireComponent (typeof (attacker))]
public class Lizard : MonoBehaviour {
	
	//public float Health;
	//public float AttackDamage;
	
	private attacker attacker;
	private Animator anim;
	
	// Use this for initialization
	void Start () {
		
		attacker = gameObject.GetComponent<attacker>();
		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D coll){
		GameObject obj = coll.gameObject;
		
		// leave method if not colliding defender
		if (!obj.GetComponent<defender> ()) {
			return;
		} else {
			attacker.Attack(obj);
		}
				
	}
	
}
