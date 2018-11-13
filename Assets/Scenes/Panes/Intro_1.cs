using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_1 : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Intro_1_scene.leftLeverActive && Intro_1_scene.rightLeverActive) {
			Intro_1_scene.completed = true;
		}
		if (Global.POI1Found) {
			Intro_1_scene.door.SetActive(false);
		}
	}

	void OnMouseDown() {
		if (gameObject.name == Intro_1_scene.leftLever.name && !Intro_1_scene.leftLeverActive) {
			Debug.Log("You clicked the left lever!");
			Intro_1_scene.leftLever.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("0-LeverOn")[0];
			Intro_1_scene.leftLeverActive = true;
		}
		if (gameObject.name == Intro_1_scene.rightLever.name && !Intro_1_scene.rightLeverActive) {
			Debug.Log("You clicked the right lever!");
			Intro_1_scene.rightLever.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("0-LeverOn")[0];
			Intro_1_scene.rightLeverActive = true;
		}
		if (gameObject.name == Intro_1_scene.door.name && Intro_1_scene.rightLeverActive && Intro_1_scene.leftLeverActive && Intro_1_scene.completed) {
			Debug.Log("You clicked the door!");
			Global.POI1Found = true;
		}
	}
}
