using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createPaddle : MonoBehaviour {

	Vector2 startPos;
	Vector2 currPos;
	Vector3 p;
	public Transform paddle;
	public Transform ball;
	bool ballActive = false;
	public PhysicsMaterial2D mat;
	Transform inst;
	int paddleLimit = 1;
		
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			startPos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			p = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			inst = Instantiate (paddle, new Vector3 (p.x, p.y, 0), Quaternion.identity);
		}

		if (Input.GetMouseButton (0)) {
			currPos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
			create ();

		}
		
	}

	void create()
	{
		Vector2 diff = startPos - currPos;
		float dis = diff.magnitude;
		Vector2 angle = (diff).normalized;
		float deg = Mathf.Atan2 (angle.y, angle.x);
		inst.eulerAngles = new Vector3 (0,0,deg * Mathf.Rad2Deg);
		inst.localScale = new Vector3 (dis * 0.02f,0.4f,1);
		inst.localPosition = new Vector3 (p.x - (angle.x * dis * 0.005f), p.y - (angle.y * dis * 0.005f), 0);
		if (dis > 500)
			dis = 500;
		if (dis < 120)
			dis = 120; 
		dis = 450 - dis;
		mat.bounciness = (((dis - 120) / 480) * 10) + 1.5f;
	}

	public void setLimit()
	{
		GameObject[] levels = GameObject.FindGameObjectsWithTag ("level");
		GameObject game = GameObject.FindGameObjectWithTag ("game");
		for (int i = 0; i < levels.Length; i++) {
			if (levels [i].GetComponent<level_details> ().levelNum == game.GetComponent<game_behaviour> ().getLevel ())
				paddleLimit = levels [i].GetComponent<level_details> ().paddleNum;
		}
	}


}
