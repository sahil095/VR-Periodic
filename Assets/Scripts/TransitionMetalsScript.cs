using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionMetalsScript : MonoBehaviour {

	// Use this for initialization
	public GameObject transitionMetals;
	void Start () {
		for (int i = -7; i < 3; i++) {
			Object.Instantiate (transitionMetals, new Vector3(i * 1.1f, 0, 0), Quaternion.identity);
			Object.Instantiate (transitionMetals, new Vector3(i * 1.1f, -1.2f, 0), Quaternion.identity);
		}

		for (int i = -6; i < 3; i++) {
			Object.Instantiate (transitionMetals, new Vector3(i * 1.1f, -2.4f, 0), Quaternion.identity);
			Object.Instantiate (transitionMetals, new Vector3(i * 1.1f, -3.6f, 0), Quaternion.identity);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
