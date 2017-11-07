using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour {

	public GameObject prefabCollectable;

	// Use this for initialization
	void Start () {

		InvokeRepeating("spawnCollectable", 2.0f, 3f);
		
	}

	void spawnCollectable()
	{
		float x = Random.Range (-8.0f, 0.0f);
		float y = Random.Range (-9.0f, 10.0f);
		Instantiate(prefabCollectable, new Vector3(x, y, 0), Quaternion.identity);
	}
}
