using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	/// <summary>
	/// Before player jump, we need to know WHEN player is landing/standing on something solid
	/// </summary>

	public float jumpSpeed = 240;
	public float forwardSpeed = 20;

	private Rigidbody2D player;
	private InputState inputState;

	void Awake() {
		player = GetComponent<Rigidbody2D> ();
		inputState = GetComponent<InputState> ();
	}

	// Update is called once per frame
	void Update () {
		if (inputState.landing) {
			if(inputState.actionButton) {
				player.velocity = new Vector2(transform.position.x < 0 ? forwardSpeed : 0, jumpSpeed);
			}
		}
	}
}
