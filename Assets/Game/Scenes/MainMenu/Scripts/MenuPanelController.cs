using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
