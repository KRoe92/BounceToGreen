using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalBehaviour : MonoBehaviour {

	int degrees;
	int a = 255;
	int range;
	float lifeSpan;
	// Use this for initialization
	void Start () {

		float scale = (Random.Range (2, 7)) / 10f;
		transform.localScale = new Vector3(scale, scale, 1);
		range = Random.Range (1, 3);
	}

	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (0 ,range * (Time.deltaTime * 0.5f),0);
		Color col = GetComponent<SpriteRenderer> ().color;
		GetComponent<SpriteRenderer> ().color = new Color (col.r, col.g, col.b, a / 255f);
		a-=range;

		lifeSpan += Time.deltaTime;
		if(lifeSpan > 4)
		{
			Destroy (gameObject);
		}

	}
}
