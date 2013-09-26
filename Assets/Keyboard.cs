using UnityEngine;
using System.Collections;

public class Keyboard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, true, false, false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
