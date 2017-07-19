using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlkalineEarthMetalsScript : MonoBehaviour {

	// Use this for initialization
	public GameObject alkalineEarthMetals;
	void Start () {
		for (int i = -2; i < 4; i++) {
			Object.Instantiate (alkalineEarthMetals, new Vector3(-8.9f, -i * 1.2f, 0), Quaternion.identity);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
