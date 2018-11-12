using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if(Input.GetKey(KeyCode.W)){
			rb.velocity = new Vector3(0,0,5);
		} else if(Input.GetKey(KeyCode.S)){
			rb.velocity = new Vector3(0,0,-5);
		} else if(Input.GetKey(KeyCode.A)){
			rb.velocity = new Vector3(-5,0,0);
		} else if(Input.GetKey(KeyCode.D)){
			rb.velocity = new Vector3(5,0,0);
		} else {
			rb.velocity = new Vector3(0,0,0);
		}

	}
}
