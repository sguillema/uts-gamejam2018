using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public Animator animator;

	//Variables
	float totalvel;
	float xvel = 0;
	float yvel = 0;
	float zvel = 0;

	//Velocity angle Definition
	Vector3 measureVector = new Vector3(0,0,10);
	float angle;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		// ReserVelocity components
		xvel = 0;
		zvel = 0;

		//Controls
		if(Input.GetKey(KeyCode.W)){
			zvel = 10;
			angle = Vector3.SignedAngle(measureVector,rb.velocity, Vector3.up);
		}
		if(Input.GetKey(KeyCode.S)){
			zvel = -10;
			angle = Vector3.SignedAngle(measureVector,rb.velocity, Vector3.up);
		}
		 if(Input.GetKey(KeyCode.A)){
			xvel = -10;
			angle = Vector3.SignedAngle(measureVector,rb.velocity, Vector3.up);
		}
		 if(Input.GetKey(KeyCode.D)){
			xvel = 10;
			angle = Vector3.SignedAngle(measureVector,rb.velocity, Vector3.up);
		} 

		//Angular segment Variables
		bool segmentFront = false;
		bool segmentBack = false;
		bool segmentLeft = false;
		bool segmentRight = false;

		//Angular segment rules
		if(angle >= -45 && angle <= 45){
			segmentFront = true;
		}
		if(Mathf.Abs(angle) >= 135){
			segmentBack = true;
		}
		if(angle >= 45 && angle <= 135){
			segmentRight = true;
		}
		if(angle <= -45 && angle >= -135){
			segmentLeft = true;
		}


		//Set angle parameter
		animator.SetBool("segmentFront",segmentFront);
		animator.SetBool("segmentBack",segmentBack);
		animator.SetBool("segmentLeft",segmentLeft);
		animator.SetBool("segmentRight",segmentRight);

		//Log angle
		Debug.Log(angle);

		//Set velocity parameter
		animator.SetFloat("velocity",rb.velocity.magnitude);

		//Diagonal velocity limiter
		/* totalvel = Mathf.Sqrt((Mathf.Pow(rb.velocity.x,2))+(Mathf.Pow(rb.velocity.z,2)));
		if(totalvel > 10){
			xvel = rb.velocity.x / Mathf.Sqrt(2);
			zvel = rb.velocity.z / Mathf.Sqrt(2);
		}*/

		//Set velocity
		rb.velocity = new Vector3(xvel,0,zvel);

		//Log velocity
		Debug.Log(rb.velocity);
	}
}
