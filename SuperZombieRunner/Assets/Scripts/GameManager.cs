using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour {

	public bool isPaused = true;
	private InputState inputState;
	public Text txtTime;
	public float runningTime = 0f;
	public float bestTime = 0f;
	private  Lose lose;
	public int gold; 
	public Text txtGold;

	void Awake () {
		inputState = GameObject.FindObjectOfType<InputState> ();
		lose = GameObject.FindObjectOfType<Lose> ();
	}

	void Start() {
		bestTime = PlayerPrefs.GetFloat ("BestTime", bestTime);
	}
	

	void Update () {
		if (inputState.actionButton) {
			isPaused = false;
		}

		if (isPaused) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}

		runningTime += Time.deltaTime;
		txtTime.text = "TIME: " + FormatTime (runningTime) + "\nBest: " + FormatTime(bestTime);

		if (lose.restart) { // Reset running time when restart
			runningTime = 0 * Time.deltaTime;
			lose.restart = false;
		}

		txtGold.text = ("Gold: " + gold);
	}

	string FormatTime (float value) {
		TimeSpan timeSpan = TimeSpan.FromSeconds (value);

		return string.Format ("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
	}
}
