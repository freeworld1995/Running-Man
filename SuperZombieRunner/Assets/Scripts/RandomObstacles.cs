using UnityEngine;
using System.Collections;

public class RandomObstacles : MonoBehaviour {

	public Sprite[] sprites;
	public Vector2 colliderOffset = Vector2.zero;

	void Start() {
		var renderer = GetComponent<SpriteRenderer> ();
		var collider = GetComponent<BoxCollider2D> ();
		renderer.sprite = sprites [Random.Range (0, sprites.Length)];

		var renSize = renderer.bounds.size;
//		print ("renSize: " + renSize);
//		print ("renSize.y: " + renSize.y);

		collider.size = renSize;
//		print ("collider.size: " + collider.size);
		collider.offset = new Vector2 (-colliderOffset.x, collider.size.y / 2 );
//		print ("collider offset: " + collider.offset);
	}
}
