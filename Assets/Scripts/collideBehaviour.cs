using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideBehaviour : MonoBehaviour {

	public GameObject bitPrefab;
	public int numOfBits;

	void Update()
	{
		if (transform.localScale.x < 5) {
			transform.localScale += new Vector3 (Time.deltaTime, Time.deltaTime, 0);
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		Vector3 pos = col.transform.position;
		for (int i = 0; i < numOfBits; i++) {
			GameObject bit = Instantiate (bitPrefab, pos, Quaternion.identity);
			bit.GetComponent<randomBehaviour>().degrees = (360/numOfBits) * i;
		}
		Destroy (gameObject);
	}
}
