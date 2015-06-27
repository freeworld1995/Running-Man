using UnityEngine;
using System.Collections;

public class PlayerAnimationManager : MonoBehaviour {

	private Animator animator;
	private InputState inputstate;

	// Use this for initialization
	void Awake () {
		animator = GetComponent<Animator> ();
		inputstate = GetComponent<InputState> ();
	}
	
	// Update is called once per frame
	void Update () {
		var running = true; // make default player running

		if (inputstate.absVelX > 0 && inputstate.absVelY < inputstate.landingThreshold) { // check if player is STANDING 
			running = false;
		}
		animator.SetBool("Running", running); 
	}
}
