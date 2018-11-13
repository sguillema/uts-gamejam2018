using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		if (gameObject.name == Intro_2_scene.suit.name && !Intro_2_scene.suitTaken) {
			Debug.Log("You took the suit");
			Intro_2_scene.suit.SetActive(false);
			Intro_2_scene.suitTaken = true;
		} else if (gameObject.name == Intro_2_scene.device.name && !Intro_2_scene.deviceTaken && Intro_2_scene.suitTaken) {
			Debug.Log("You took the device");
			Intro_2_scene.device.SetActive(false);
			Intro_2_scene.deviceTaken= true;
			Global.POI2Found = true;
		}
		// if (gameObject.name == Intro_2_scene.suit.name) {
		// 	Debug.Log("You took the suit");
		// }
	}
}
