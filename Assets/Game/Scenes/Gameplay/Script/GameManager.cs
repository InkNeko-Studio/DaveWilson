using System;
using System.Collections;
using System.Collections.Generic;
using Game.Scenes.GameOver.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance;

	private void Awake()
	{
		Instance = this;
	}

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

	public void TakeDamage()
	{
		playerlife--;
		if (playerlife <= 0)
		{
			GameOverController.Instance.points = playerscore;
			SceneManager.LoadScene("GameOver");
		}
	}
}
