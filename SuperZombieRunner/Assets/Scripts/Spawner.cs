using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] prefabs;
	public float delay = 2.0f;
	public Vector2 delayRange = new Vector2 (1, 2);
	public bool active = true;

	// Use this for initialization
	void Start () {
		resetDelay ();
		StartCoroutine (EnemyGenerator ());
	}

	IEnumerator EnemyGenerator() {
		yield return new WaitForSeconds (delay);

		if (active) {
			var newTransform = transform;

			Instantiate(prefabs[Random.Range(0, prefabs.Length)], newTransform.position, Quaternion.identity);
			resetDelay();
		}

		StartCoroutine (EnemyGenerator ());
	}
	
	void resetDelay() {
		delay = Random.Range (delayRange.x, delayRange.y);
	}


}
