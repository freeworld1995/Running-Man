using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lose : MonoBehaviour {
	public Text text;
	public bool restart = false;
	private GameObject reservedPlayer;
	public GameObject pausedCanvas;
	private bool playerState;
	private GameManager gameManager;

	void Awake() {
		gameManager = GameObject.FindObjectOfType<GameManager> ();
	}

	void OnTriggerEnter2D (Collider2D col) {
		reservedPlayer = col.gameObject;
		reservedPlayer.SetActive (false);
		pausedCanvas.SetActive (true);
		restart = true;
		if (gameManager.runningTime > gameManager.bestTime) {
			gameManager.bestTime = gameManager.runningTime;
			PlayerPrefs.SetFloat("BestTime", gameManager.bestTime); // Save best time value even when turn game off 
		}
		text.text = "Restart";
		gameManager.isPaused = true;
	}

	void Update() {
 		print (gameManager.isPaused);
	}

	public void Restart () {
		reservedPlayer.transform.position = new Vector3 (0, 115, 0);
		reservedPlayer.SetActive (true);
		pausedCanvas.SetActive(false);
		gameManager.isPaused = false;
	}
}
