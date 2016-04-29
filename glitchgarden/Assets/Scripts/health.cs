using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {

	public float totalHP;

	private attacker attacker;
	
	public void TakeDamage (float damage){
		Debug.Log (damage + " to be taken");

		totalHP -= damage;

		if (totalHP <= 0) {
			if (gameObject.GetComponent<defender>()){
				//attacker.Walk();
				DestoryObj();
			} else {
				DestoryObj();
			}

		}

	}

	public void DestoryObj(){
		Destroy (gameObject);
	}
}

