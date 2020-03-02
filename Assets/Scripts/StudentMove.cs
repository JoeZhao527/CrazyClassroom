using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentMove : MonoBehaviour {
	private Rigidbody stu;

	// Use this for initialization
	void Start () {
		stu = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.S))
			stu.AddForce (Vector3.forward* 1000f);

		if (Input.GetKey (KeyCode.W))
			stu.AddForce (Vector3.back * 1000f);

		if (Input.GetKey(KeyCode.D))
			stu.AddForce (Vector3.left* 1000f);

		if (Input.GetKey(KeyCode.A))
			stu.AddForce (Vector3.right* 1000f);
	}
}
