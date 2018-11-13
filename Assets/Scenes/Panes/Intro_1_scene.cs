using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Intro_1_scene{
	public static GameObject door = GameObject.Find("podDoor");
	public static GameObject leftLever = GameObject.Find("lever_l");
	public static GameObject rightLever = GameObject.Find("lever_r");

	public static bool leftLeverActive = false;
	public static bool rightLeverActive = false;

	public static bool completed = false;
}
