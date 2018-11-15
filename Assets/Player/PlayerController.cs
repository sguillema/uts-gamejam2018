using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;
	public float speed;

	void start (){
		
		//Assign Rigidbody component
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
		
		//Get inputs
		float moveHorizontal = Input.GetAxisRaw("Horizontal");
		float moveVertical = Input.GetAxisRaw("Vertical");

		//Assign velocity vector
		Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical) * speed * Time.deltaTime;

		//Apply velocity vector
		rb.velocity = movement;

		//Velocity limiter
		rb.velocity = Vector3.ClampMagnitude(rb.velocity, speed * Time.deltaTime);
	}
}
