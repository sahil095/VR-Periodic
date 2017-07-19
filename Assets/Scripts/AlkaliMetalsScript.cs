using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlkaliMetalsScript : MonoBehaviour {

	// Use this for initialization

	//public GameObject alkaliMetals;
	public TextMesh t;
	void Start () {
	//	for (int i = -2; i < 4; i++) {
	//		Object.Instantiate (alkaliMetals, new Vector3 (-10, -i * 1.2f, 0), Quaternion.identity);
	//	}
		t = GetComponent<TextMesh>();
		//for (int i = 0; i < 5; i++) {
			if (GameObject.Find ("Li")) {
				t.text = "1";
			}
		//}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
