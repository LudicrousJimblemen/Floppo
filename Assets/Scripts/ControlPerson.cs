using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ControlPerson : MonoBehaviour {
	public Person Person;
	
	private void Update() {
		bool w = Input.GetKey(KeyCode.W);
		bool s = Input.GetKey(KeyCode.S);
		bool e = Input.GetKey(KeyCode.E);
		bool q = Input.GetKey(KeyCode.Q);
		bool d = Input.GetKey(KeyCode.D);
		bool a = Input.GetKey(KeyCode.A);
		
		Person.Act(
			w || s ? (w ? 1 : -1) : 0,
			e || q ? (e ? 1 : -1) : 0,
			d || a ? (d ? 1 : -1) : 0);
	}
}
