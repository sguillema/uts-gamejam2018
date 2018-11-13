using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test_controller : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Global.POI1Found){
			GetComponent<Renderer>().enabled = true;
		} else {
			GetComponent<Renderer>().enabled = false;
		}
	}

	void OnMouseDown() {
		if(Global.POI1Found){
			Debug.Log("You clicked me");
			SceneManager.LoadScene("Sandbox");
			// if (gameObject.tag == GameObject.Find("New Sprite").tag) {
			// 	Debug.Log("You clicked the left lever!");
			// }
		}
	}
}
