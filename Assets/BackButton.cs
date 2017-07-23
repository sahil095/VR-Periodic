using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour {

	public GameObject myImage;
	public GameObject periodicTable;
	void OnMouseDown() {
		
	 	periodicTable.SetActive(true);
        Debug.Log ("Clicked");
		myImage.SetActive(false);	
	}
}
