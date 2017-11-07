using System.Collections.Generic;
using UnityEngine;

public class randomBehaviour : MonoBehaviour {

	public int degrees;
	public float speed;

	float lifeSpan;
	// Use this for initialization
	void Start () {

		//degrees = Random.Range (0, 360);
		float scale = (Random.Range (2, 5)) / 10f;
		transform.localScale = new Vector3(scale, scale, 1);

	}

	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (Mathf.Cos(degrees) * speed,Mathf.Sin(degrees) * speed,0);
		lifeSpan += Time.deltaTime;
		if(lifeSpan > 2)
		{
			Destroy (gameObject);
		}
	}
}