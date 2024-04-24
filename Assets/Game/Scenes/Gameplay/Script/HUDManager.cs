using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour {

	// Use this for initialization
	public Text life;
	public Text score;
	public Text bombs;
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		life.text = GameManager.Instance.playerlife.ToString();
		score.text = GameManager.Instance.playerscore.ToString();
		bombs.text = GameManager.Instance.playerboms.ToString();
	}
}
