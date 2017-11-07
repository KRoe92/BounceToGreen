using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_behaviour : MonoBehaviour {

	int currentLevel = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public int getLevel()
	{
		return currentLevel;
	}

	public void setLevel(int level)
	{
		currentLevel = level;
	}


	public void increaseLevel()
	{
		currentLevel++;
		transform.GetChild(currentLevel - 1).gameObject.SetActive (true);
		transform.GetChild(currentLevel - 2).gameObject.SetActive (false);
	}
}
