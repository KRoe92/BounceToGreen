using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle_Control : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		transform.position = new Vector3 (1000, 0, 0);
	}
}
