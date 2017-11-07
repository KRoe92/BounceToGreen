using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBubbles : MonoBehaviour {

	public GameObject bubblePrefab;
	private float nextActionTime = 0.0f;
	public float period = 5f;
	float range;

	void Start () {
	}

	void Update () {
		if (Time.time > nextActionTime ) {
			nextActionTime += period;
			range = Random.Range (-6, 6) / 10f;
			Instantiate (bubblePrefab, transform.position + new Vector3 (Random.Range (-6, 6) / 10f, 0.2f, 0), Quaternion.identity);
		}
	}


}
