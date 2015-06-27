using UnityEngine;
using System.Collections;

public class CoinManager : MonoBehaviour {

	private GameManager gm;

	void Awake() {
		gm = GameObject.FindObjectOfType<GameManager> ();
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.CompareTag ("Coin")) {
			GetComponent<AudioSource>().Play();
			Destroy(col.gameObject);
			gm.gold += 10;
		}
	}
}
