using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOver : MonoBehaviour {


	public GameObject myImage;
	void OnMouseEnter() {
		Debug.Log ("Mouse Enter");
		myImage.SetActive(true);
	}

	void OnMouseExit() {
		Debug.Log ("Mouse Exit");
		myImage.SetActive (false);
	}
}
