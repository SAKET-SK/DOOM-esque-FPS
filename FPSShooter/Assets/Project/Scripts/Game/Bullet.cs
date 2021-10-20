using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 8f;
	public float lifeDuration = 2f;
	public int damage = 5;

	private float lifeTimer;

	private bool shotByPlayer;
	public bool ShotByPlayer { get { return shotByPlayer; } set { shotByPlayer = value; } }

	// Use this for initialization
	void OnEnable () {
		lifeTimer = lifeDuration;
	}
	
	// Update is called once per frame
	void Update () {
		// Make the bullet move.
		transform.position += transform.forward * speed * Time.deltaTime;

		// Check if the bullet should be destroyed.
		lifeTimer -= Time.deltaTime;
		if (lifeTimer <= 0f) {
			gameObject.SetActive (false);
		}
	}
}
