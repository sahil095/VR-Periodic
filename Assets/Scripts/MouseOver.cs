using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOver : MonoBehaviour {


	public GameObject myImage;
	void OnMouseDown() {
		
	 	GameObject[] obj = GameObject.FindGameObjectsWithTag("periodic");
 		obj[0].SetActive(false);
        Debug.Log ("Mouse Clicked");
		myImage.SetActive(true);
		GameObject[] obj = GameObject.FindGameObjectsWithTag("Li");
 		obj[0].SetActive(true);		
	}

}
