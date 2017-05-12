using System.Linq;
using UnityEngine;

public class Network {
	public int InputCount;
	public Layer[] Layers;
	
	public float[] LastInputs;
	
	public Network(int inputCount, int[] hiddenLayers, int outputCount) {
		InputCount = inputCount;
		Layers = new Layer[hiddenLayers.Length + 1];
		
		Layers[0] = new Layer(inputCount, hiddenLayers[0]);
		for (int i = 1; i < hiddenLayers.Length; i++) {
			Layers[i] = new Layer(hiddenLayers[i - 1], hiddenLayers[i]);
		}
		
		// Output layer
		Layers[hiddenLayers.Length] = new Layer(hiddenLayers[hiddenLayers.Length - 1], outputCount);
	}
	
	public float[] Feed(float[] inputs) {
		inputs = inputs.Select(i => Mathf.Clamp(i, -1f, 1f)).ToArray();
		
		LastInputs = inputs;
		
		float[] outputs = Layers[0].Feed(inputs);
		
		for (int i = 1; i < Layers.Length; i++) {
			outputs = Layers[i].Feed(outputs);
		}
		
		return outputs;
	}
	
	public virtual void Mutate(float rad) {
		foreach (var layer in Layers) {
			foreach (var neuron in layer.Perceptrons) {
				for (int i = 0; i < neuron.Weights.Length; i++) {
					neuron.Weights[i] += Random.Range(-Mathf.Abs(neuron.Weights[i]) * rad, Mathf.Abs(neuron.Weights[i]) * rad);
				}
			}
		}
	}
}
