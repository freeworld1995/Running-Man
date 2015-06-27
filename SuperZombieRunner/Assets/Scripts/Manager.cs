using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

	private bool isPaused = true;
	private InputState inputState;
	
	void Awake () {
		inputState = GameObject.FindObjectOfType<InputState> ();
	}
	
	void Start () {
	}
	
	void Update () {
		if (inputState.actionButton) {
			Time.timeScale = 1;
			isPaused = false;
		}
		
		if (isPaused == true) {
			Time.timeScale = 0;
		} 
	}
}
