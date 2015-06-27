using UnityEngine;
using System.Collections;

public class InputState : MonoBehaviour {

	public bool actionButton; // check if button is press 
	public float absVelX = 0f;
	public float absVelY = 0f;
	public bool landing; // check if player is standing
	public float landingThreshold = 1; // compare with the AbsVelY so we know if player is standing or not

	private Rigidbody2D player; // link to player Rigidbody2D

	void Awake () {
		player = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		actionButton = Input.anyKeyDown; // return true if 1st frame player hit any key or button
	}

	void FixedUpdate() {
		absVelX = Mathf.Abs (player.velocity.x);
		absVelY = Mathf.Abs (player.velocity.y);

		landing = absVelY <= landingThreshold;
	}
}
