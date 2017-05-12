using System;
using UnityEngine;

public class Layer {
	public Perceptron[] Perceptrons;
	
	private int inputCount;
	
	public Layer(int inputCount, int neuronCount) {
		Perceptrons = new Perceptron[neuronCount];
		for (int i = 0; i < Perceptrons.Length; i++) {
			Perceptrons[i] = new Perceptron(inputCount);
		}
		this.inputCount = inputCount;
	}
	
	public float[] Feed(float[] inputs) {
		float[] outputs = new float[Perceptrons.Length];
		
		for (int i = 0; i < Perceptrons.Length; i++) {
			outputs[i] = Perceptrons[i].Feed(inputs);
		}
		
		return outputs;
	}
}