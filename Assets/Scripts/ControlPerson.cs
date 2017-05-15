using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ControlPerson : MonoBehaviour {
	private Person person;
	
	private void Awake() {
		person = GetComponent<Person>();
		if (GetComponent<SkinnedMeshRenderer>()) {
			GetComponent<SkinnedMeshRenderer>().material.color = Color.red;
		}
	}
	
	private void Update() {
		person.Act(
			Input.GetAxis("X"),
			Input.GetAxis("Y"),
			Input.GetAxis("Z"));
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			foreach (var rigidbody in FindObjectsOfType<Rigidbody>()) {
				if (rigidbody.gameObject != person.gameObject) {
					rigidbody.AddExplosionForce(2000f, person.transform.position, 15f, 12f);
				}
			}
		}
	}
}
