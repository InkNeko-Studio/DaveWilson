using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour {

	// Use this for initialization
	public Text life;
	public Text score;
	public Text bombs;
	public GameManager gm;
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		life.text = gm.playerlife.ToString();
		score.text = gm.playerscore.ToString();
		bombs.text = gm.playerboms.ToString();
	}
}
