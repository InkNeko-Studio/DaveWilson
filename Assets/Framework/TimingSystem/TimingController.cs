﻿using System;
using System.Collections;
using UnityEngine;

namespace Framework.TimingSystem
{
	public class TimingController : MonoBehaviour
	{
		public static TimingController Instance;

		private void Awake()
		{
			Instance = this;
		}

		public void RunAfter(Action action, float time)
		{
			StartCoroutine (RunAfterCoroutine (action, time));
		}

		private IEnumerator RunAfterCoroutine(Action action, float time)
		{
			yield return new WaitForSeconds (time);
			action ();
		}
	}
}
