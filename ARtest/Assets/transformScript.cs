using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformScript : MonoBehaviour {

	public GameObject okObject;
	public GameObject failObject;
	float currentVal;

	bool objectToggle;

	int buffer;

	// Use this for initialization
	void Start () {
		failObject.SetActive (false);
		currentVal = 0;
		objectToggle = true;
		buffer = 0;
	}
	
	// Update is called once per frame
	void Update () {
//		currentVal = Input.touchCount;
//		Input.touches.Length

		//		print (Input.GetAxis ("Horizontal"));
		if (Input.touches.Length != 0  ) {
			failObject.SetActive (objectToggle);
			okObject.SetActive(!objectToggle);

			objectToggle = !objectToggle;
			//			sign.GetComponent<Renderer> ().enabled = false;
		} 
	}
}
