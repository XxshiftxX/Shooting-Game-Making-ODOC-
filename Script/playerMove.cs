using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

	public Rigidbody2D myRigidbody;

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			myRigidbody.velocity = Vector2.left * 5;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			myRigidbody.velocity = Vector2.right * 5;
		}
	}
}
