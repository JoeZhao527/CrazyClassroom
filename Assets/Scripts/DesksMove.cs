using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesksMove : MonoBehaviour {
	private Transform desk;
	// Use this for initialization
	void Start () {
		desk = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Z))
			desk.Translate (Vector3.up * -4, Space.Self);
		if (Input.GetKeyDown(KeyCode.X))
			desk.Translate (Vector3.up * 4, Space.Self);
	}

	void OnTriggerEnter(Collider coll) {
		if (coll.gameObject.name == "Student")
			desk.Translate (Vector3.up * 2, Space.Self);
	}
	void OnTriggerExit(Collider coll) {
		if (coll.gameObject.name == "Student")
			desk.Translate (Vector3.up * -2, Space.Self);
	}
}
