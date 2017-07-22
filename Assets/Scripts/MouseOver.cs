using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOver : MonoBehaviour {


	public GameObject myImage;
	void OnMouseDown() {
		Debug.Log ("Mouse Clicked");
		myImage.SetActive(true);
		//Not working
		//Object.DontDestroyOnLoad(myImage);
		// Application.LoadLevel("SecondScene");	
	}

}
