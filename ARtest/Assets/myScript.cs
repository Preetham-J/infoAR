using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myScript : MonoBehaviour {

	public GameObject sign;
	public GameObject oldSign;
	public GameObject newSign;

	// Use this for initialization
	void Start () {
		
	}

	float currentVal = 0;

	bool isOn = true;
		
	// Update is called once per frame
	void Update () {
//		currentVal = Input.GetAxis ("Horizontal");
		currentVal = Input.touchCount;
	
//		print (Input.GetAxis ("Horizontal"));
		if (currentVal != 0){
			sign.SetActive(!isOn);

			isOn = !isOn;

			DestroyObject (sign);
//			sign.GetComponent<Renderer> ().enabled = false;
		}


	}
}
