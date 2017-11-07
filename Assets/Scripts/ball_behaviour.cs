using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_behaviour : MonoBehaviour {

	public GameObject paddle;
	float successTimer;

	public GameObject reset;
	public GameObject Next;
	bool succeeding;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (succeeding) {
			successTimer += Time.deltaTime;
			if (successTimer > 2) {
				reset.SetActive (false);
				Next.SetActive (true);
				successTimer = 0;
			}
		}

	}

	public void setStartingPos()
	{
		GameObject[] starts = GameObject.FindGameObjectsWithTag ("start");
		for (int i = 0; i < starts.Length; i++) {
			if (starts [i].activeInHierarchy)
				transform.position = starts [i].transform.position;
		}
		GetComponent<Rigidbody2D> ().velocity = new Vector2(0, 0);
		GameObject[] paddles = GameObject.FindGameObjectsWithTag ("paddle");
		for(int i = 0; i < paddles.Length; i++)
		{
			Destroy(paddles[i]);
		}

		paddle.GetComponent<createPaddle> ().setLimit ();
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "goal")
		{
			gameObject.GetComponent<SpriteRenderer> ().color = new Color (44f/255, 1, 152f/255, 1);
			succeeding = true;
		}
	}

	void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.tag == "goal") {
			gameObject.GetComponent<SpriteRenderer> ().color = new Color (1, 22, 8f / 255, 1);
			succeeding = false;
			successTimer = 0;
		}
	}
}
