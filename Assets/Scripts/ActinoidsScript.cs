using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActinoidsScript : MonoBehaviour {

	// Use this for initialization
	public GameObject actinoids;
	void Start () {
		for (int i = -6; i < 9; i++) {
			Object.Instantiate (actinoids, new Vector3(i * 1.1f, -7.5f, 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
