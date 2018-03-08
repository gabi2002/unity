using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {
	public Light flashLight;
	private bool isActive;
	private bool isNotActive;

	// Use this for initialization
	void Start () {
		isActive = true;
		isNotActive = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.F))
		{
			if (isActive == false) {
				flashLight.enabled = true;
				isActive = true;
			} 
			else if (isActive == true) 
			{
				flashLight.enabled = false;
				isActive = false;
			}

			else if (isNotActive == true) {
				flashLight.enabled = false;
				isNotActive = false;
			} 
			else if (isNotActive == false) 
			{
				flashLight.enabled = true;
				isNotActive = true;
			}
		}
		
	}
}
