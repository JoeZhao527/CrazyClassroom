using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCam : MonoBehaviour {
	private GameObject cam;
	private bool s;
	// Use this for initialization
	void Start () {
		s = true;
		cam.SetActive (s);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.T)) {
			s = (s == false);
			cam.SetActive (s);
		}
	}
}
