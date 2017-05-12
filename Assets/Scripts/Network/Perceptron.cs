using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perceptron {
	public int InputCount;
	public float[] Weights;
	
	public float[] LastInputs;
	public float LastOutput;
	
	public Perceptron(int inputCount) {
		this.InputCount = inputCount;
		
		// This is one larger than the input count to make room for the bias value.
		Weights = new float[inputCount + 1];
		
		for (int i = 0; i < Weights.Length; i++) {
			Weights[i] = Random.Range(-1, 1);
		}
	}
	
	public float Feed(float[] inputs) {
		LastInputs = inputs;
		
		float sum = 0;
		// This is one less than the weight count to make room for the bias.
		for (int i = 0; i < Weights.Length - 1; i++) {
			sum += inputs[i] * Weights[i];
		}
		
		// Add the bias value (multiplied by 1) to the sum.
		sum += Weights[Weights.Length - 1];
		
		float result = Activation(sum);
		LastOutput = result;
		
		return result;
	}
	
	private float Activation(float sum) {
		// Sign function (a step function).
		// return sum > 0 ? 1 : -1;
		
		// Error function (a sigmoid curve).
		return (2f / (1 + Mathf.Pow(2.71828182f, -(sum * 6f)))) - 1;
	}
}
