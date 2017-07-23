using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonScript : MonoBehaviour , IVirtualButtonEventHandler  {

	private GameObject myObject;
	void Start () {
		Debug.Log("added");
		// myObject = GameObject.Find("LiButton");
		// myObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
		for (int i = 0; i < vbs.Length; ++i) {
		    // Register with the virtual buttons TrackableBehaviour
		    vbs[i].RegisterEventHandler(this);
		}
		 
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
            Debug.Log("Helllllloooooooooo");
   	}		

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Goooooodbyeeee");
    }
}