using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Shared.Player.Scripts
{
	public class CharacterBombs : MonoBehaviour
	{

		public GameObject bomb;
		public Transform bombpoint;
		public GameManager gm;

		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
			if (Input.GetMouseButtonDown(1) && gm.playerboms > 0)
			{
				Dropbomb();
				gm.playerboms--;
			}
		}

		private void Dropbomb()
		{
			Instantiate(bomb, bombpoint.position, bombpoint.rotation);
		}

		
	}
}