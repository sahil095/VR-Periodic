using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoorMetalsScript : MonoBehaviour {

	// Use this for initialization
	public GameObject poorMetals;
	void Start () {
		for (int i = -1; i < 4; i++) {
			Object.Instantiate (poorMetals, new Vector3(3.3f, -i * 1.2f, 0), Quaternion.identity);
		}

		for (int i = 1; i < 4; i++) {
			Object.Instantiate (poorMetals, new Vector3(4.4f, -i * 1.2f, 0), Quaternion.identity);
		}

		for (int i = 2; i < 4; i++) {
			Object.Instantiate (poorMetals, new Vector3(5.5f, -i * 1.2f, 0), Quaternion.identity);
		}

		for (int i = 3; i < 4; i++) {
			Object.Instantiate (poorMetals, new Vector3(6.6f, -i * 1.2f, 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
