using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCrate : MonoBehaviour {

	[Header("Visuals")]
	public GameObject container;
	public float rotationSpeed = 180f;

	[Header("Gameplay")]
	public int health = 50;

	void Update () {
		container.transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime);
	}
}
