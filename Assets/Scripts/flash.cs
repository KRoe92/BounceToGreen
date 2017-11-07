using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flash : MonoBehaviour {

	bool increase;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
		Color c = GetComponent<Text> ().color;
		float speed = -1;
		if (increase)
			speed *= -1;
		GetComponent<Text> ().color = new Color (c.r, c.g, c.b, c.a + Time.deltaTime / speed);


		if (GetComponent<Text> ().color.a * 255 > 240)
			increase = false;
		if (GetComponent<Text> ().color.a * 255 < 2)
			increase = true;

	}
}
