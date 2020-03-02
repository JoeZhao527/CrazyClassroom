using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show : MonoBehaviour {
	private Rigidbody ball;
	// Use this for initialization
	void Start () {
		ball = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.name == "Student") {
			if (Input.GetKey(KeyCode.Space)) {
				ball.AddForce (Vector3.up * 1000f);

			}
		}
	}
}
