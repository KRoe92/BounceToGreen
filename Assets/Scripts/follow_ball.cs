using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_ball : MonoBehaviour {

	public Transform ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float posX = ball.position.x;
		float posY = ball.position.y;
		//transform.position = new Vector3 (0, posY, -10);

	}
}
