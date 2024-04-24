using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	public int playerlife;
	public int playerboms;
	public int playerscore;
	void Start ()
	{
		playerlife = 5;
		playerboms = 2;
		playerscore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MoreScore()
	{
		playerscore++;
	}
}
