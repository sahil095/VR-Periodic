using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanthanoidsScript : MonoBehaviour {

	// Use this for initialization
	public GameObject lanthanoids;
	void Start () {
		for (int i = -6; i < 9; i++) {
			Object.Instantiate (lanthanoids, new Vector3(i * 1.1f, -6, 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
