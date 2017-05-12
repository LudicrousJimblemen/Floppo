using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Person : MonoBehaviour {
	public float Force = 800f;
	
	private Rigidbody rigidbody;
	
	private void Awake() {
		rigidbody = GetComponent<Rigidbody>();
	}
	
	public void Act(float X, float Y, float Z) {
		rigidbody.AddRelativeTorque(new Vector3(Mathf.Lerp(-Force, Force, (X + 1) / 2f), 0, 0), ForceMode.Acceleration);
		rigidbody.AddRelativeTorque(new Vector3(0, Mathf.Lerp(-Force, Force, (Y + 1) / 2f), 0), ForceMode.Acceleration);
		rigidbody.AddRelativeTorque(new Vector3(0, 0, Mathf.Lerp(-Force, Force, (Z + 1) / 2f)), ForceMode.Acceleration);
	}
}