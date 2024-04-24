﻿using Framework.TimingSystem;
using UnityEngine;

namespace Game.Scenes.MainMenu.Scripts
{
	public class MenuPanelController : MonoBehaviour
	{
		public GameObject sceneMask;

		private void Start ()
		{
			TimingController.Instance.RunAfter (() => {
				sceneMask.SetActive(false);
			}, 1f);
		}

		void Update ()
		{
		
		}
	}
}
