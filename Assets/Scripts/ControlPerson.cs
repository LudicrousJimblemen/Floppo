using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ControlPerson : MonoBehaviour {
	private Person person;
	
	private void Awake() {
		person = GetComponent<Person>();
		if (GetComponentInChildren<SkinnedMeshRenderer>()) {
			GetComponentInChildren<SkinnedMeshRenderer>().material.color = Color.red;
		}
	}
	
	private void Update() {
		person.Act(
			Input.GetAxis("X1"),
			Input.GetAxis("Y1"),
			Input.GetAxis("Z1"),
			Input.GetAxis("X2"),
			Input.GetAxis("Y2"),
			Input.GetAxis("Z2"));
	}
}
