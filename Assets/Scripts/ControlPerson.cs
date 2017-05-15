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
	}
}
