using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ControlPerson : MonoBehaviour {
	public Person Person;
	
	private void Update() {
		Person.Act(
			Input.GetAxis("X"),
			Input.GetAxis("Y"),
			Input.GetAxis("Z"));
	}
}
