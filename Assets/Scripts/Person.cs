using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Person : MonoBehaviour {
	public float Force = 800f;
	
	private Rigidbody lower;
	private Rigidbody upper;
	
	private void Awake() {
		lower = GetComponentsInChildren<Rigidbody>()[0];
		upper = GetComponentsInChildren<Rigidbody>()[1];
	}
	
	public void Act(float X1, float Y1, float Z1, float X2, float Y2, float Z2) {
		upper.AddRelativeTorque(new Vector3(Mathf.Lerp(-Force, Force, (X1 + 1) / 2f), 0, 0), ForceMode.Acceleration);
		upper.AddRelativeTorque(new Vector3(0, Mathf.Lerp(-Force, Force, (Y1 + 1) / 2f), 0), ForceMode.Acceleration);
		upper.AddRelativeTorque(new Vector3(0, 0, Mathf.Lerp(-Force, Force, (Z1 + 1) / 2f)), ForceMode.Acceleration);
		lower.AddRelativeTorque(new Vector3(Mathf.Lerp(-Force, Force, (X2 + 1) / 2f), 0, 0), ForceMode.Acceleration);
		lower.AddRelativeTorque(new Vector3(0, Mathf.Lerp(-Force, Force, (Y2 + 1) / 2f), 0), ForceMode.Acceleration);
		lower.AddRelativeTorque(new Vector3(0, 0, Mathf.Lerp(-Force, Force, (Z2 + 1) / 2f)), ForceMode.Acceleration);
	}
}